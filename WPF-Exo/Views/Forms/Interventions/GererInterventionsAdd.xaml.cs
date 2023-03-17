using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WPF_Exo.Views.Detail.Prestataires;
using WPF_Exo.Views.Subviews.Interventions;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Forms.Interventions
{
    /// <summary>
    /// Logique d'interaction pour GererInterventionsAdd.xaml
    /// </summary>
    public partial class GererInterventionsAdd : Page
    {
        Frame frmListView;
        Frame frmGererList;
        Prestataire? prestataire;
        public GererInterventionsAdd(Frame frmListView, Frame frmGererList, Prestataire? prestataire)
        {
            InitializeComponent();
            this.frmListView = frmListView;
            this.frmGererList = frmGererList;
            this.prestataire = prestataire;

            if (prestataire == null)
            {
                frmGerer.Navigate(new GererPrestataireForm());
            } else
            {
                frmGerer.Navigate(new PrestataireAfficherDetail(prestataire, frmGerer));
            }
            
        }

        private void frmGerer_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.frmGererList.Navigate(new GererPrestataireAdd(frmListView, frmGererList, null));
            this.frmListView.Navigate(new ListInterventionsView(frmGererList, frmListView));
        }
    }
}
