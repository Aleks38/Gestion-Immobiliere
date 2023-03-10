using System.Windows.Controls;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Interventions
{
    /// <summary>
    /// Logique d'interaction pour InterventionAfficherDetail.xaml
    /// </summary>
    public partial class InterventionAfficherDetail : Page
    {
        public InterventionAfficherDetail(Intervention intervention)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            Biens theBien = ctx.Biens.Find(intervention.BienId);
            lblNomBien.Content = theBien.Nom;

            ImoContext ctx2 = new ImoContext();
            Prestataire thePrestataire = ctx2.Prestataires.Find(intervention.ListPrestaId[intervention.ListPrestaId.Count - 1]);
            lblNomPresta.Content = thePrestataire.Nom;

            lblDate.Content = intervention.DateIntervention;
            lblMontant.Content = intervention.MontantTTC;
            lblInformation.Content = intervention.Information;
        }

        private void btnModifier_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
