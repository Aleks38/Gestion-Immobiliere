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
using WPF_Exo.Views;

namespace WPF_TP.Views
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.MainFrame.Navigate(new HomeView());
        }

        private void btnBiens_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new BienView());
        }

        private void btnPret_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PretsView());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnAccueil_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new HomeView());
        }

        private void btnInterventions_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new InterventionsView());

        }
    }
}
