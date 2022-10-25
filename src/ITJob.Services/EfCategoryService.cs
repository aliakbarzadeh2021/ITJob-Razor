using System.Collections.Generic;
using System.Linq;
using ITJob.Common.GuardToolkit;
using ITJob.Repository.Context;
using ITJob.DomainModels;
using ITJob.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ITJob.Services
{
    public class EfCategoryService : ICategoryService
    {
        IUnitOfWork _uow;
        readonly DbSet<Category> _categories;
        public EfCategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _uow.CheckArgumentIsNull(nameof(_uow));

            _categories = _uow.Set<Category>();
        }

        public void AddNewCategory(Category category)
        {
           _categories.Add(category);
        }

        public IList<Category> GetAllCategories()
        {
            return _categories.ToList();
        }
    }
}
