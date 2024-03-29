﻿#pragma checksum "..\..\ProWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9D1F70319E0033EB8ABE2661373FBCA736853CF8E6D4C130628CD2981555294B"
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
    /// ProWindow
    /// </summary>
    public partial class ProWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProNameLabel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProTypeLabel;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProPercenteLabel;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ProDeadlineLabel;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProInsert;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnProBack;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProTypeTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProPercenteTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ProWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProDeadlineTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/wpfApp;component/prowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProWindow.xaml"
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
            this.ProNameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ProTypeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.ProPercenteLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ProDeadlineLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnProInsert = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\ProWindow.xaml"
            this.btnProInsert.Click += new System.Windows.RoutedEventHandler(this.btnProInsert_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnProBack = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ProWindow.xaml"
            this.btnProBack.Click += new System.Windows.RoutedEventHandler(this.btnProBack_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ProNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ProTypeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ProPercenteTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ProDeadlineTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

