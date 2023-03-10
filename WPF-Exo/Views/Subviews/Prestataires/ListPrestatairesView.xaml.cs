using System.Windows.Controls;
using WPF_Exo.Views.Detail.Prestataires;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour ListPrestatairesView.xaml
    /// </summary>
    public partial class ListPrestatairesView : Page
    {
        Frame frmGerer;
        public ListPrestatairesView(Frame frmGerer)
        {
            InitializeComponent();
            this.frmGerer = frmGerer;
            ImoContext ctx = ImoContext.getInstance();

            foreach (Prestataire prestataire in ctx.Prestataires)
            {
                this.listViewPrestataires.Items.Add(prestataire);
            }
        }

        private void listViewPrestataire_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Prestataire prestataire = (Prestataire)(sender as ListBox).SelectedItem;
            if (prestataire != null)
            {
                PrestataireAfficherDetail prestataireDetail = new PrestataireAfficherDetail(prestataire);

                frmGerer.Navigate(prestataireDetail);
            }
        }
    }
}
