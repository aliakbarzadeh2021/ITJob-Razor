using System.Collections.Generic;
using System.Threading.Tasks;
using ITJob.DomainModels.Identity;
using System.Security.Claims;
using ITJob.ViewModels.Identity;

namespace ITJob.Services.Contracts.Identity
{
    public interface ISiteStatService
    {
        Task<List<User>> GetOnlineUsersListAsync(int numbersToTake, int minutesToTake);

        Task<List<User>> GetTodayBirthdayListAsync();

        Task UpdateUserLastVisitDateTimeAsync(ClaimsPrincipal claimsPrincipal);

        Task<AgeStatViewModel> GetUsersAverageAge();
    }
}