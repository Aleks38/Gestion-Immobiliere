﻿#pragma checksum "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79EDEB3F139BD75FF0D1CDEDDD10F483DB1453E0"
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
using WPF_Exo.Views.Detail.Prets;


namespace WPF_Exo.Views.Detail.Prets {
    
    
    /// <summary>
    /// PretAfficherDetail
    /// </summary>
    public partial class PretAfficherDetail : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAjouter;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNomBien;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblApport;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMensualite;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDuree;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSupprimer;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModifier;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-Exo;component/views/detail/prets/pretafficherdetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblAjouter = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblNomBien = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblApport = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblMensualite = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblDuree = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.btnSupprimer = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
            this.btnSupprimer.Click += new System.Windows.RoutedEventHandler(this.btnSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnModifier = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\..\Views\Detail\Prets\PretAfficherDetail.xaml"
            this.btnModifier.Click += new System.Windows.RoutedEventHandler(this.btnModifier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

