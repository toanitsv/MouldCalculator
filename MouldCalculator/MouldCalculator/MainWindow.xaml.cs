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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MouldCalculator.Views;

namespace MouldCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuItemLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void miSupplier_Click(object sender, RoutedEventArgs e)
        {
            SupplierWindow window = new SupplierWindow();
            window.Show();
        }
    }
}
