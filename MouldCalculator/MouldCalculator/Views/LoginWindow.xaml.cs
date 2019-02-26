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
using MouldCalculator.Helper;

namespace MouldCalculator.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUserName.Focus();
            btnLogin.IsDefault = true;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            txtPassword.Clear();
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.ShowDialog();
            this.Show();
        }

        private void mDChipSupplier_Click(object sender, RoutedEventArgs e)
        {
            if (mDChipSupplier.Icon.ToString().Equals("EN"))
            {
                mDChipSupplier.Icon = "VN";
                mDChipSupplier.Content = "English";
                mDChipSupplier.FlowDirection = FlowDirection.RightToLeft;
                LanguageHelper.SetLanguageDictionary(ELanguage.VietNamese);
                this.InitializeComponent();

                return;
            }
            if (mDChipSupplier.Icon.ToString().Equals("VN"))
            {
                mDChipSupplier.Icon = "EN";
                mDChipSupplier.Content = "Tiếng Việt";
                mDChipSupplier.FlowDirection = FlowDirection.LeftToRight;
                LanguageHelper.SetLanguageDictionary(ELanguage.English);
                this.InitializeComponent();
                return;
            }

        }

        private void mdColorZoneTitle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void btnWindowClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
