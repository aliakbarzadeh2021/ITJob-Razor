﻿using System.Collections.Generic;
using ITJob.DomainModels;

namespace ITJob.Services.Contracts
{
    public interface ICategoryService
    {
        void AddNewCategory(Category category);
        IList<Category> GetAllCategories();
    }
}