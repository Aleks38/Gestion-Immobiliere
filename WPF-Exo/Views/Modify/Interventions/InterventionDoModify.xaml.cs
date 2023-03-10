using System.Windows.Controls;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Modify.Interventions
{
    /// <summary>
    /// Logique d'interaction pour InterventionDoModify.xaml
    /// </summary>
    public partial class InterventionDoModify : Page
    {
        public InterventionDoModify(Intervention theIntervention)
        {
            InitializeComponent();

            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                cmbBien.Items.Add(bien);
            }

            foreach (Biens bien in ctx.Biens)
            {
                cmbPresta.Items.Add(bien);
            }

            txtDate.Text = theIntervention.DateIntervention;
            txtMontant.Text = theIntervention.MontantTTC.ToString();
            txtInformation.Text = theIntervention.Information;
        }
    }
}
