using CarGallerry.Commands;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
using CarGallery.Domain.AdditionalClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CarGallerry.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public FilterUserControl filterUserControl { get; set; }
        public RelayCommand FilterBtnCommand { get; set; }
        public RelayCommand BrandCommand { get; set; }
        public RelayCommand BanCommand { get; set; }
        public RelayCommand CarColorCommand { get; set; }
        public ObservableCollection<Car> Cars { get; set; }
        public IRepository<Car> _repo { get; set; }
        public MainViewModel(MainWindow mainWindow, ICarsRepository pathRepository)
        {
            _repo = pathRepository;
            Cars = new ObservableCollection<Car>();
            Cars = _repo.GetAllData();
            filterUserControl = new FilterUserControl();
            FilterBtnCommand = new RelayCommand((sender) =>
              {
                  mainWindow.userGrid.Children.Add(filterUserControl);
              });
            Helper.MainWindow = mainWindow;
            Helper.Cars = Cars;

        }
    }
}
