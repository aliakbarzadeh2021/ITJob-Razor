using System.Collections.Generic;
using ITJob.DomainModels;

namespace ITJob.Services.Contracts
{
    public interface IProductService
    {
        void AddNewProduct(Product product);
        IList<Product> GetAllProducts();
    }
}