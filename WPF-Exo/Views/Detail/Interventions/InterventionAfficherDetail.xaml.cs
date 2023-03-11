using System.Windows.Controls;
using WPF_Exo.Views.Modify.Interventions;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Interventions
{
    /// <summary>
    /// Logique d'interaction pour InterventionAfficherDetail.xaml
    /// </summary>
    public partial class InterventionAfficherDetail : Page
    {
        Frame frmGerer;
        Intervention intervention;
        public InterventionAfficherDetail(Intervention intervention, Frame Gerer)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            this.frmGerer = Gerer;
            this.intervention = intervention;

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
            this.frmGerer.Navigate(new InterventionDoModify(intervention));
        }
    }
}
