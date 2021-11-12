using CarGallerry.Commands;
using CarGallerry.Domain.AdditionalClasses;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using CarGallery.Domain.AdditionalClasses;
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
        public RelayCommand SearchBtnClick { get; set; }
        public RelayCommand BrandComboBoxSelectionChanged { get; set; }
        public RelayCommand ColorComboBoxSelectionChanged { get; set; }
        public RelayCommand BanTypeComboBoxSelectionChanged { get; set; }
   
        public ObservableCollection<Car> Cars { get; set; }
        public FilterUserControlViewModel(FilterUserControl filterUserControl,BanTypesRepository banTypesRepository,
            CarColorsRepository carColorsRepository, BrandsRepository brandsRepository)
        {
            Brands = new ObservableCollection<Brand>();
            CarColors = new ObservableCollection<CarColor>();
            BanTypes = new ObservableCollection<BanType>();
            _brand = brandsRepository;
            _carColor = carColorsRepository;
            _bandType = banTypesRepository;
            Cars = new ObservableCollection<Car>();
        
            filterUserControl.banTypeCmbbx.ItemsSource = _bandType.GetAllData().Select(bt => bt.Name);
            filterUserControl.markaCmbbx.ItemsSource = _brand.GetAllData().Select(bt => bt.Name);
            filterUserControl.colorCmbbx.ItemsSource = _carColor.GetAllData().Select(bt => bt.Name);


            BrandComboBoxSelectionChanged = new RelayCommand((sender) => 
            {
                try
                {
                    Cars = ObserverHelper.ToObservableCollection(Helper.Cars.Where(c => c.Brand.Name.ToString() == filterUserControl.markaCmbbx.SelectedItem.ToString()));
                    Helper.MainWindow.Listbox.ItemsSource = Cars;
                }
                catch (Exception)
                {

                }
            });

            ColorComboBoxSelectionChanged = new RelayCommand((sender) =>
            {
                try
                {
                    Helper.MainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.CarColor.Name.ToString() == filterUserControl.colorCmbbx.SelectedItem.ToString()));
                }
                catch (Exception)
                {

                }
            });

            BanTypeComboBoxSelectionChanged = new RelayCommand((sender) =>
            {
                try
                {
                    Helper.MainWindow.Listbox.ItemsSource = ObserverHelper.ToObservableCollection(Cars.Where(c => c.BanType.Name.ToString() == filterUserControl.banTypeCmbbx.SelectedItem.ToString()));
                }
                catch (Exception)
                {

                }
            });
            SearchBtnClick = new RelayCommand((sender) =>
            {
                try
                {
                   Helper.Cars1 = ObserverHelper.ToObservableCollection(Cars.Where(c =>
                   c.Milage.Value >= decimal.Parse(filterUserControl.minTxtbx.Text) &&
                   c.Milage.Value <= decimal.Parse(filterUserControl.maxTxtbx.Text) &&
                   c.Price.Value >= decimal.Parse(filterUserControl.minPriceTxtbx.Text) &&
                   c.Price.Value <= decimal.Parse(filterUserControl.maxPriceTxtbx.Text) &&
                   c.IsNew==filterUserControl.newRadiobtn.IsChecked));
                   Helper.MainWindow.Listbox.ItemsSource = Helper.Cars1;

                }
                catch (Exception)
                {

                }
                   
                
            });
         
        }




    }
}
