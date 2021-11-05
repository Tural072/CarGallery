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
    public class CarColorsRepository : ICarColorsRepository
    {
        public DataClasses1DataContext DataClasses1DataContext { get; set; }
        public CarColorsRepository()
        {
            DataClasses1DataContext = new DataClasses1DataContext();
        }
        public void AddData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(CarColor data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<CarColor> GetAllData()
        {
            var carColor = from CarColors in DataClasses1DataContext.CarColors
                           select CarColors;
            return ObserverHelper.ToObservableCollection(carColor);
        }


        public CarColor GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(CarColor data)
        {
            throw new NotImplementedException();
        }
    }
}
