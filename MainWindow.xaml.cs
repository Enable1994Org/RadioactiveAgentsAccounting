using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RadioactiveAgentsAccounting.Models;

namespace RadioactiveAgentsAccounting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataContext db = new DataContext();
        public MainWindow()
        {
            InitializeComponent();
            /*District district = new District() { Name = "New Student" };
            db.Districts.Add(district);
            db.SaveChanges();*/
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource districtViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("districtViewSource")));
            db.Districts.Load();
            districtViewSource.Source = db.Districts.Local;
            this.districtDataGrid.Items.Refresh();
            // Load data by setting the CollectionViewSource.Source property:
            // districtViewSource.Source = [generic data source]

            System.Windows.Data.CollectionViewSource provinceViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("provinceViewSource")));
            db.Provinces.Load();
            provinceViewSource.Source = db.Provinces.Local;
            this.provinceDataGrid.Items.Refresh();
            // Load data by setting the CollectionViewSource.Source property:
            // provinceViewSource.Source = [generic data source]
        }
    }
}
