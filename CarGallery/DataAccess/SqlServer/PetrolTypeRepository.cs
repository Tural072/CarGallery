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
    public class PetrolTypeRepository : IPetrolTypeRepository
    {
        public DataClasses1DataContext DataClasses1DataContext { get; set; }
        public PetrolTypeRepository()
        {
            DataClasses1DataContext = new DataClasses1DataContext();
        }
        public void AddData(PetrolType data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(PetrolType data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<PetrolType> GetAllData()
        {
            var petrolType = from PetrolType in DataClasses1DataContext.PetrolTypes
                          select PetrolType;
            return ObserverHelper.ToObservableCollection(petrolType);
        }

        public PetrolType GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(PetrolType data)
        {
            throw new NotImplementedException();
        }
    }
}
