using System.Windows.Controls;
using System.Windows.Navigation;
using WPF_Exo.Views.Forms.Prets;
using WPF_Exo.Views.Subviews.Pret;

namespace WPF_Exo.Views
{
    /// <summary>
    /// Logique d'interaction pour PretsView.xaml
    /// </summary>
    public partial class PretsView : Page
    {
        public PretsView()
        {
            InitializeComponent();
            ListPretsView pretsView = new ListPretsView(this.frmGerer);
            frmListPrets.Navigate(pretsView);
            frmGerer.Navigate(new GererPretsForm(pretsView));
        }

        private void frmListPrets_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void frmGerer_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
