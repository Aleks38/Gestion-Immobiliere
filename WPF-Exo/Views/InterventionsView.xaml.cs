using System.Windows.Controls;
using System.Windows.Navigation;
using WPF_Exo.Views.Forms.Interventions;
using WPF_Exo.Views.Subviews.Interventions;

namespace WPF_Exo.Views
{
    /// <summary>
    /// Logique d'interaction pour InterventionsView.xaml
    /// </summary>
    public partial class InterventionsView : Page
    {
        public InterventionsView()
        {
            InitializeComponent();
            
            this.frmListInterventions.Navigate(new ListInterventionsView());
            this.frmGerer.Navigate(new GererPrestataireAdd(this.frmGerer));
        }

        private void frmListIntervention_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void frmGererIntervention_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
