using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ITJob.ViewModels.Identity;

namespace ITJob.Services.Contracts.Identity
{
    public interface IAppLogItemsService
    {
        Task DeleteAllAsync(string logLevel = "");
        Task DeleteAsync(int logItemId);
        Task DeleteOlderThanAsync(DateTimeOffset cutoffDateUtc, string logLevel = "");
        Task<int> GetCountAsync(string logLevel = "");
        Task<PagedAppLogItemsViewModel> GetPagedAppLogItemsAsync(int pageNumber, int pageSize, SortOrder sortOrder, string logLevel = "");
    }
}