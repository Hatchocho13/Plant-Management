﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F29F34468A50BC6148A9A4D69AF28E5208C1E9A0CDFFD840F27220CEECE9CFD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace PlantManagement.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel InitialPanel;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainPanel;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageUserButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageAdministrativeUnitButton;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManagePlantVarietyButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManagePesticidesButton;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageFertilizersButton;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ManageProductionButton;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ReportButton;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl MainContent;
        
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
            System.Uri resourceLocater = new System.Uri("/PlantManagement;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            this.InitialPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 9 "..\..\..\Views\MainWindow.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\Views\MainWindow.xaml"
            this.RegisterButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MainPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            
            #line 39 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MyAccountButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 40 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ManageUserButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Views\MainWindow.xaml"
            this.ManageUserButton.Click += new System.Windows.RoutedEventHandler(this.ManageUserButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ManageAdministrativeUnitButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Views\MainWindow.xaml"
            this.ManageAdministrativeUnitButton.Click += new System.Windows.RoutedEventHandler(this.ManageAdministrativeUnitButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ManagePlantVarietyButton = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\Views\MainWindow.xaml"
            this.ManagePlantVarietyButton.Click += new System.Windows.RoutedEventHandler(this.ManagePlantVarietyButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ManagePesticidesButton = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\Views\MainWindow.xaml"
            this.ManagePesticidesButton.Click += new System.Windows.RoutedEventHandler(this.ManagePesticidesButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ManageFertilizersButton = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\Views\MainWindow.xaml"
            this.ManageFertilizersButton.Click += new System.Windows.RoutedEventHandler(this.ManageFertilizersButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ManageProductionButton = ((System.Windows.Controls.Button)(target));
            
            #line 98 "..\..\..\Views\MainWindow.xaml"
            this.ManageProductionButton.Click += new System.Windows.RoutedEventHandler(this.ManageProductionButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.ReportButton = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\Views\MainWindow.xaml"
            this.ReportButton.Click += new System.Windows.RoutedEventHandler(this.ReportButton_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.MainContent = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

