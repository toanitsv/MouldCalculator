﻿#pragma checksum "..\..\..\Views\LoginWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84AD18EE3382B3EF59E6C66C185615DE12681A49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using MouldCalculator.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MouldCalculator.Views {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorZone mdColorZoneTitle;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridTitle;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWindowClose;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUserName;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLogin;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Views\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Chip mDChipSupplier;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MouldCalculator;component/views/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\LoginWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 20 "..\..\..\Views\LoginWindow.xaml"
            ((MouldCalculator.Views.LoginWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mdColorZoneTitle = ((MaterialDesignThemes.Wpf.ColorZone)(target));
            
            #line 27 "..\..\..\Views\LoginWindow.xaml"
            this.mdColorZoneTitle.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.mdColorZoneTitle_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gridTitle = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.btnWindowClose = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Views\LoginWindow.xaml"
            this.btnWindowClose.Click += new System.Windows.RoutedEventHandler(this.btnWindowClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.btnLogin = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Views\LoginWindow.xaml"
            this.btnLogin.Click += new System.Windows.RoutedEventHandler(this.btnLogin_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Views\LoginWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnWindowClose_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.mDChipSupplier = ((MaterialDesignThemes.Wpf.Chip)(target));
            
            #line 69 "..\..\..\Views\LoginWindow.xaml"
            this.mDChipSupplier.Click += new System.Windows.RoutedEventHandler(this.mDChipSupplier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

