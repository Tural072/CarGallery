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
    public class BanTypesRepository : IBanTypeRepository
    {
        public DataClasses1DataContext DataClasses1DataContext { get; set; }
        public void AddData(BanType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(BanType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<BanType> GetAllData()
        {
            var banType = from BanType in DataClasses1DataContext.BanTypes
                          select BanType;
            return ObserverHelper.ToObservableCollection(banType);
        }

        public BanType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(BanType data)
        {
            throw new NotImplementedException();
        }
    }
}
