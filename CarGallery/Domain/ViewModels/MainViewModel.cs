using CarGallerry.Commands;
using CarGallerry.Views;
using CarGallery.DataAccess.SqlServer;
using CarGallery.Domain.Abstractions;
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
        public ObservableCollection<ImagePath> ImagePaths { get; set; }
        public IRepository<ImagePath> _repo { get; set; }
        public MainViewModel(MainWindow mainWindow,IImagePathRepository pathRepository)
        {
            _repo = pathRepository;
            ImagePaths = new ObservableCollection<ImagePath>();
            ImagePaths = _repo.GetAllData();
            filterUserControl = new FilterUserControl();
            FilterBtnCommand = new RelayCommand((sender) =>
              {
                  mainWindow.userGrid.Children.Add(filterUserControl);
              });
        }
    }
}
