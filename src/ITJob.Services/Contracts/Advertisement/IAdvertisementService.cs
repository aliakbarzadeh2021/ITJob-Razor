using System;
using System.Collections.Generic;
using System.Text;
using ad = ITJob.DomainModels.Advertisement.Advertisement;

namespace ITJob.Services.Contracts.Advertisement
{
    public interface IAdvertisementService
    {
        void AddNewAdvertisement(ad advertisement);

        void UpdateAdvertisement(ad advertisement);

        void DeleteAdvertisement(ad advertisement);

        void ConfirmAdvertisement(ad advertisement);
        IList<ad> GetAllCategories();
    }
}
