﻿#pragma checksum "..\..\EmpListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75C1D7AFC520F51A080402F3CAC2D7EFEDF6B5C69E18E95F1CB173FAA84D6B94"
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
using wpfApp;


namespace wpfApp {
    
    
    /// <summary>
    /// EmpListWindow
    /// </summary>
    public partial class EmpListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\EmpListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\EmpListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExitEmpList;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\EmpListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBackEmpList;
        
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
            System.Uri resourceLocater = new System.Uri("/wpfApp;component/emplistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EmpListWindow.xaml"
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
            
            #line 8 "..\..\EmpListWindow.xaml"
            ((wpfApp.EmpListWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\EmpListWindow.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnExitEmpList = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\EmpListWindow.xaml"
            this.btnExitEmpList.Click += new System.Windows.RoutedEventHandler(this.btnExitEmpList_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnBackEmpList = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\EmpListWindow.xaml"
            this.btnBackEmpList.Click += new System.Windows.RoutedEventHandler(this.btnBackEmpList_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

