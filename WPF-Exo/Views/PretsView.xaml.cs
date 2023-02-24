using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

            frmListPrets.Navigate(new ListPretsView());
            frmGerer.Navigate(new GererPretsForm());
        }

        private void frmListPrets_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void frmGerer_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
