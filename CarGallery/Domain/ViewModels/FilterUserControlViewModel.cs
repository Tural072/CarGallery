using CarGallerry.Domain.AdditionalClasses;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
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
        public FilterUserControlViewModel(FilterUserControl filterUserControl,BanTypesRepository banTypesRepository,
            CarColorsRepository carColorsRepository, BrandsRepository brandsRepository)
        {
            Brands = new ObservableCollection<Brand>();
            CarColors = new ObservableCollection<CarColor>();
            BanTypes = new ObservableCollection<BanType>();
            _brand = brandsRepository;
            _carColor = carColorsRepository;
            _bandType = banTypesRepository;
        
            filterUserControl.banTypeCmbbx.ItemsSource = _bandType.GetAllData().Select(bt => bt.Name);
            filterUserControl.markaCmbbx.ItemsSource = _brand.GetAllData().Select(bt => bt.Name);
            filterUserControl.colorCmbbx.ItemsSource = _carColor.GetAllData().Select(bt => bt.Name);
        }
    }
}
