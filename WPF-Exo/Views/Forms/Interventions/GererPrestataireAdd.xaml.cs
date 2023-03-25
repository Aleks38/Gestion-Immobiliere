using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WPF_Exo.Views.Detail.Interventions;
using WPF_Exo.Views.Detail.Prestataires;
using WPF_Exo.Views.Subviews;
using WPF_Exo.Views.Subviews.Interventions;
using WPF_Exo.Views.Subviews.Prestataires;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Forms.Interventions
{
    /// <summary>
    /// Logique d'interaction pour GererPrestataireAdd.xaml
    /// </summary>
    public partial class GererPrestataireAdd : Page
    {
        Frame frmListView;
        Frame frmGererInter;
        Intervention? interventions;
        private IObserver obs;
        public GererPrestataireAdd(Frame frmListView, Frame frmGererInter, Intervention? interventions)
        {
            InitializeComponent();
            this.frmListView = frmListView;
            this.frmGererInter = frmGererInter;
            this.obs = obs;

            if (interventions == null)
            {
                frmGerer.Navigate(new GererInterventionsForm());
            }
            else
            {
                frmGerer.Navigate(new InterventionAfficherDetail(interventions, frmGerer));
            }
            

            
        }

        private void frmGerer_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.frmGererInter.Navigate(new GererInterventionsAdd(frmListView, frmGererInter, null));
            this.frmListView.Navigate(new ListPrestatairesView(frmGererInter, frmListView));

        }
    }
}
