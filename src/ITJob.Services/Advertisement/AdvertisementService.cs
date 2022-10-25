using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITJob.Common.GuardToolkit;
using ITJob.Repository.Context;
using ITJob.Services.Contracts.Advertisement;
using Microsoft.EntityFrameworkCore;
using ad =ITJob.DomainModels.Advertisement.Advertisement;

namespace ITJob.Services.Advertisement
{
    public class AdvertisementService : IAdvertisementService
    {
        IUnitOfWork _uow;
        readonly DbSet<ad> _advertisements;

        public AdvertisementService(IUnitOfWork uow)
        {
            _uow = uow;
            _uow.CheckArgumentIsNull(nameof(_uow));
            _advertisements = _uow.Set<ad>();
        }

        public void AddNewAdvertisement(ad advertisement)
        {
            _advertisements.Add(advertisement);
        }

        public void UpdateAdvertisement(ad advertisement)
        {
            _advertisements.Update(advertisement);
        }

        public void DeleteAdvertisement(ad advertisement)
        {
            throw new NotImplementedException();
        }

        public void ConfirmAdvertisement(ad advertisement)
        {
             
        }

        public IList<ad> GetAllCategories()
        {
            return _advertisements.ToList();
        }
    }
}
