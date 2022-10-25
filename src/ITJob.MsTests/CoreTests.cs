using ITJob.Common.GuardToolkit;
using ITJob.Common.WebToolkit;
using ITJob.Repository.Context;
using ITJob.DomainModels.Identity;
using ITJob.Services.Contracts.Identity;
using ITJob.Services.Identity;
using ITJob.ViewModels.Identity.Settings;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Design.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using Microsoft.AspNetCore.Hosting.Internal;
using ITJob.IocConfig;

namespace ITJob.MsTests
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2510
    /// </summary>
    [TestClass]
    public class CoreTests
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IOptionsSnapshot<SiteSettings> _siteSettings;

        public CoreTests()
        {
            var services = new ServiceCollection();
            services.AddOptions();
            services.AddScoped<IHostingEnvironment, HostingEnvironment>();

            var configuration = new ConfigurationBuilder()
                                .AddJsonFile("ITJob/appsettings.json", reloadOnChange: true, optional: false)
                                .Build();
            services.AddSingleton<IConfigurationRoot>(provider => configuration);
            services.Configure<SiteSettings>(options => configuration.Bind(options));
            services.AddEntityFrameworkInMemoryDatabase().AddDbContext<ApplicationDbContext>(ServiceLifetime.Scoped);

            // Adds all of the ASP.NET Core Identity related services and configurations at once.
            services.AddCustomIdentityServices();

            services.AddRazorViewRenderer();
            services.AddMvcActionsDiscoveryService();
            services.AddProtectionProviderService();
            services.AddCloudscribePagination();

            _serviceProvider = services.BuildServiceProvider();

            _siteSettings = _serviceProvider.GetRequiredService<IOptionsSnapshot<SiteSettings>>();
            _siteSettings.Value.ActiveDatabase = ActiveDatabase.InMemoryDatabase;

            var identityDbInitialize = _serviceProvider.GetRequiredService<IIdentityDbInitializer>();
            identityDbInitialize.SeedData();
        }

        [TestMethod]
        public void Test_UserAdmin_Exists()
        {
            _serviceProvider.RunScopedContext(context =>
            {
                var users = context.Set<User>();
                Assert.IsTrue(users.Any(x => x.UserName == "Admin"));
            });
        }
    }
}