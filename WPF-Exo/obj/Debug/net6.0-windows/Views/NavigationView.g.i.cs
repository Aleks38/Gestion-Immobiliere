﻿#pragma checksum "..\..\..\..\Views\NavigationView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4754F449141ADD1782E2FE0B25B84BA8DF224C35"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WPF_TP.Views;


namespace WPF_TP.Views {
    
    
    /// <summary>
    /// NavigationView
    /// </summary>
    public partial class NavigationView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\Views\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccueil;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Views\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBiens;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Views\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInterventions;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Views\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPret;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\NavigationView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-Exo;component/views/navigationview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\NavigationView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnAccueil = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Views\NavigationView.xaml"
            this.btnAccueil.Click += new System.Windows.RoutedEventHandler(this.btnAccueil_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnBiens = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Views\NavigationView.xaml"
            this.btnBiens.Click += new System.Windows.RoutedEventHandler(this.btnBiens_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnInterventions = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Views\NavigationView.xaml"
            this.btnInterventions.Click += new System.Windows.RoutedEventHandler(this.btnInterventions_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnPret = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Views\NavigationView.xaml"
            this.btnPret.Click += new System.Windows.RoutedEventHandler(this.btnPret_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 16 "..\..\..\..\Views\NavigationView.xaml"
            this.MainFrame.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.MainFrame_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

