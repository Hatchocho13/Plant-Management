﻿#pragma checksum "..\..\..\Views\QuanLyPhanBonView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33BE56948756169CD8690D840828A0F0073165A4D12A3A2B6EA150F03CD7818F"
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
    /// QuanLyPhanBonView
    /// </summary>
    public partial class QuanLyPhanBonView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 20 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel SearchOptions;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DataGridSection;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridPhanBon;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border AddNewForm;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TenPhanBonTextBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThongTinTextBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoSoSanXuatTextBox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Views\QuanLyPhanBonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CoSoBuonBanTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/PlantManagement;component/views/quanlyphanbonview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\QuanLyPhanBonView.xaml"
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
            
            #line 18 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddNewButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\..\Views\QuanLyPhanBonView.xaml"
            this.SearchTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.SearchTextBox_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 21 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 31 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchOptions = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            
            #line 34 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchByTenPhanBon_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 35 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchByCoSoSanXuat_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 36 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchByCoSoBuonBan_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DataGridSection = ((System.Windows.Controls.Grid)(target));
            return;
            case 10:
            this.DataGridPhanBon = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 13:
            this.AddNewForm = ((System.Windows.Controls.Border)(target));
            return;
            case 14:
            this.TenPhanBonTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.ThongTinTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.CoSoSanXuatTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 17:
            this.CoSoBuonBanTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 18:
            
            #line 96 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 97 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 11:
            
            #line 55 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 56 "..\..\..\Views\QuanLyPhanBonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

