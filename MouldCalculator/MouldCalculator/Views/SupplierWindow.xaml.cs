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
using MouldCalculator.Models;
using MouldCalculator.Controllers;

namespace MouldCalculator.Views
{
    /// <summary>
    /// Interaction logic for SupplierWindow.xaml
    /// </summary>
    public partial class SupplierWindow : Window
    {
        public SupplierWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var supplierInsert = new Supplier() {
                SupplierID = 112,
                SupplierName = "Giang Pocurpine",
                Description = "giang bi ham",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now
            };
            SupplierController.Add(supplierInsert);
        }
    }
}
