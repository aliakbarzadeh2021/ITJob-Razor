using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using ITJob.Common.GuardToolkit;
using ITJob.Services.Contracts.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ITJob.Services.Identity
{
    /// <summary>
    ///  To register it: services.AddScoped<IClaimsTransformation, ApplicationClaimsTransformation>();
    ///  How to add existing db user's claims to the user's active directory claims.
    /// </summary>
    public class ApplicationClaimsTransformation : IClaimsTransformation
    {
        private readonly IApplicationUserManager _userManager;
        private readonly IApplicationRoleManager _roleManager;
        private readonly ILogger<ApplicationClaimsTransformation> _logger;

        public ApplicationClaimsTransformation(
            IApplicationUserManager userManager,
            IApplicationRoleManager roleManager,
            ILogger<ApplicationClaimsTransformation> logger)
        {
            _userManager = userManager;
            _userManager.CheckArgumentIsNull(nameof(userManager));

            _roleManager = roleManager;
            _roleManager.CheckArgumentIsNull(nameof(roleManager));

            _logger = logger;
            _logger.CheckArgumentIsNull(nameof(logger));
        }

        public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var identity = principal.Identity as ClaimsIdentity;
            if (identity == null)
            {
                return principal;
            }

            var claims = await addExistingUserClaimsAsync(identity).ConfigureAwait(false);
            identity.AddClaims(claims);

            return principal;
        }

        private async Task<IEnumerable<Claim>> addExistingUserClaimsAsync(IIdentity identity)
        {
            var claims = new List<Claim>();
            var user = await _userManager.Users.Include(u => u.Claims)
                                                 .FirstOrDefaultAsync(u => u.UserName == identity.Name)
                                                 .ConfigureAwait(false);
            if (user == null)
            {
                _logger.LogError($"Couldn't find {identity.Name}.");
                return claims;
            }

            var Options = new ClaimsIdentityOptions();

            claims.Add(new Claim(Options.UserIdClaimType, user.Id.ToString()));
            claims.Add(new Claim(Options.UserNameClaimType, user.UserName));

            if (_userManager.SupportsUserSecurityStamp)
            {
                claims.Add(new Claim(Options.SecurityStampClaimType,
                    await _userManager.GetSecurityStampAsync(user).ConfigureAwait(false)));
            }

            if (_userManager.SupportsUserClaim)
            {
                claims.AddRange(await _userManager.GetClaimsAsync(user).ConfigureAwait(false));
            }

            if (_userManager.SupportsUserRole)
            {
                var roles = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
                foreach (var roleName in roles)
                {
                    claims.Add(new Claim(Options.RoleClaimType, roleName));
                    if (_roleManager.SupportsRoleClaims)
                    {
                        var role = await _roleManager.FindByNameAsync(roleName).ConfigureAwait(false);
                        if (role != null)
                        {
                            claims.AddRange(await _roleManager.GetClaimsAsync(role).ConfigureAwait(false));
                        }
                    }
                }
            }

            return claims;
        }
    }
}