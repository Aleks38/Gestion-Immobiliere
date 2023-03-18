using System.Linq;
using System.Windows.Controls;
using WPF_Exo.Views.Detail.Prestataires;
using WPF_Exo.Views.Forms.Interventions;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour ListPrestatairesView.xaml
    /// </summary>
    public partial class ListPrestatairesView : Page, IObserver
    {
        Frame frmGerer;
        Frame frmList;
        public ListPrestatairesView(Frame frmGerer, Frame frmList)
        {
            InitializeComponent();
            this.frmGerer = frmGerer;
            this.frmList = frmList;

            refreshList();
        }

        private void listViewPrestataire_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Prestataire prestataire = (Prestataire)(sender as ListBox).SelectedItem;
            if (prestataire != null)
            {
                //PrestataireAfficherDetail prestataireDetail = new PrestataireAfficherDetail(prestataire, frmGerer, this);

                GererInterventionsAdd gererInterventionsAdd = new GererInterventionsAdd(frmList, frmGerer, prestataire);

                frmGerer.Navigate(gererInterventionsAdd);
            }
        }

        private void refreshList()
        {
            ImoContext ctx = ImoContext.getInstance();

            this.listViewPrestataires.Items.Clear();

            foreach (Prestataire prestataire in ctx.Prestataires)
            {
                this.listViewPrestataires.Items.Add(prestataire);
            }
        }
        public void update()
        {
            this.refreshList();
        }
    }
}
