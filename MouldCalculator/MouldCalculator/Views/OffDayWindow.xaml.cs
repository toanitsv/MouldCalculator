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
        private OffDayViewModel offDayViewModel = new OffDayViewModel();
        public OffDayWindow()
        {
            this.DataContext = offDayViewModel;
            InitializeComponent();
        }
    }
}
