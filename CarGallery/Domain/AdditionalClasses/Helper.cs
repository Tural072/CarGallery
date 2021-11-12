using CarGallerry;
using CarGallery.DataAccess.SqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGallery.Domain.AdditionalClasses
{
    public class Helper
    {
        public static MainWindow MainWindow { get; set; }
        public static ObservableCollection<Car> Cars { get; set; }
        public static ObservableCollection<Car> Cars1 { get; set; }
        public Helper()
        {
            MainWindow = new MainWindow();
            Cars = new ObservableCollection<Car>();
            Cars1 = new ObservableCollection<Car>();
        }
    }
}
