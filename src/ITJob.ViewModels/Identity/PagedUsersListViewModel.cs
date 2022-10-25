using System.Collections.Generic;
using ITJob.DomainModels.Identity;
using cloudscribe.Web.Pagination;

namespace ITJob.ViewModels.Identity
{
    public class PagedUsersListViewModel
    {
        public PagedUsersListViewModel()
        {
            Paging = new PaginationSettings();
        }

        public List<User> Users { get; set; }

        public List<Role> Roles { get; set; }

        public PaginationSettings Paging { get; set; }
    }
}
