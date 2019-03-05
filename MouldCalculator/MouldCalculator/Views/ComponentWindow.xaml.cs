﻿using System;
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
using MouldCalculator.ViewModels;

namespace MouldCalculator.Views
{
    /// <summary>
    /// Interaction logic for ComponentWindow.xaml
    /// </summary>
    public partial class ComponentWindow : Window
    {
        //private ComponentViewModel componentViewModel = new ComponentViewModel();
        public ComponentWindow()
        {
            this.DataContext = new ComponentViewModel();
            InitializeComponent();
        }
    }
}
