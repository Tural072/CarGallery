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

    public class ImagePathRepository : IImagePathRepository
    {
        public DataClasses1DataContext DataClasses1DataContext { get; set; }
        public ImagePathRepository()
        {
            DataClasses1DataContext = new DataClasses1DataContext();
        }
        public void AddData(ImagePath data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(ImagePath data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<ImagePath> GetAllData()
        {
            var image = from s in DataClasses1DataContext.ImagePaths
                        select s;
            return ObserverHelper.ToObservableCollection(image);
        }

        public ImagePath GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(ImagePath data)
        {
            throw new NotImplementedException();
        }
    }
}
