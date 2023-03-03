using System.Windows.Controls;
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

            lblNomBien.Content = "";
            lblNomPresta.Content = "";
            lblDate.Content = intervention.DateIntervention;
            lblMontant.Content = intervention.MontantTTC;
            lblInformation.Content = intervention.Information;
        }
    }
}
