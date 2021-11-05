using CarGallerry.Domain.AdditionalClasses;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Text;

namespace CarGallerry.Domain.ViewModels
{
    public class FilterUserControlViewModel:BaseViewModel
    {
        public IRepository<Brand> _brand { get; set; }
        public IRepository<CarColor> _carColor { get; set; }
        public IRepository<BanType> _bandType { get; set; }
        public ObservableCollection<Brand> Brands { get; set; }
        public ObservableCollection<CarColor> CarColors { get; set; }
        public ObservableCollection<BanType> BanTypes { get; set; }
        public FilterUserControlViewModel(FilterUserControl filterUserControl)
        {
            Brands = new ObservableCollection<Brand>();
            CarColors = new ObservableCollection<CarColor>();
            BanTypes = new ObservableCollection<BanType>();
            Brands = _brand.GetAllData();
            CarColors = _carColor.GetAllData();
            BanTypes = _bandType.GetAllData();
        }
    }
}
