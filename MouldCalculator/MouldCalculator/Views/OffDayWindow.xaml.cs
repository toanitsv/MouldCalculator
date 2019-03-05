using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using MouldCalculator.ViewModels;

namespace MouldCalculator.Views
{
    /// <summary>
    /// Interaction logic for OffDayWindow.xaml
    /// </summary>
    public partial class OffDayWindow : Window
    {
        public OffDayViewModel offDayViewModel = new OffDayViewModel();
        public OffDayWindow()
        {
            this.DataContext = offDayViewModel;            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReloadComponentList();
        }
        private void btnRemoveSupplier_Click(object sender, RoutedEventArgs e)
        {
            var buttonClicked = sender as Button;
            var supplierID = (int)buttonClicked.Tag;
            var supplierRemove = offDayViewModel.SupplierList.SingleOrDefault(s => s.SupplierID == supplierID);
            offDayViewModel.SupplierList.Remove(supplierRemove);
            ReloadComponentList();
        }
        private void ReloadComponentList()
        {
            icComponent.ItemsSource = null;
            icComponent.ItemsSource = offDayViewModel.SupplierList;
            ((OffDayViewModel)this.DataContext).SupplierList = offDayViewModel.SupplierList;
        }

        
    }
}
