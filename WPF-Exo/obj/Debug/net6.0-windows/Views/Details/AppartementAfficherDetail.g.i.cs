﻿#pragma checksum "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9FEF30FCBBAFB2C4A8AC044B4806F95A2C91AA3E"
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
using WPF_Exo.Views.Details;


namespace WPF_Exo.Views.Details {
    
    
    /// <summary>
    /// AppartementAfficherDetail
    /// </summary>
    public partial class AppartementAfficherDetail : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrmHabitableAfficherDetail;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEtage;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblAscenseur;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblChauffageCommun;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF-Exo;component/views/details/appartementafficherdetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FrmHabitableAfficherDetail = ((System.Windows.Controls.Frame)(target));
            
            #line 33 "..\..\..\..\..\Views\Details\AppartementAfficherDetail.xaml"
            this.FrmHabitableAfficherDetail.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.FrmHabitableAfficherDetail_Navigated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblEtage = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblAscenseur = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblChauffageCommun = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

