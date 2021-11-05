using CarGallerry.Domain.AdditionalClasses;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.DataAccess.SqlServer
{
    public class BrandsRepository : IBrandsRepostory
    {
        public DataClasses1DataContext DataClasses1DataContext { get; set; }
        public void AddData(Brand data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Brand data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Brand> GetAllData()
        {
            var brands = from Brand in DataClasses1DataContext.Brands
                          select Brand;
            return ObserverHelper.ToObservableCollection(brands);
        }

        public Brand GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Brand data)
        {
            throw new NotImplementedException();
        }
    }
}
