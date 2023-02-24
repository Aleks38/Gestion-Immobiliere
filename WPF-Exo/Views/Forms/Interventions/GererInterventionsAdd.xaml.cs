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

namespace WPF_Exo.Views.Forms.Interventions
{
    /// <summary>
    /// Logique d'interaction pour GererInterventionsAdd.xaml
    /// </summary>
    public partial class GererInterventionsAdd : Page
    {
        Frame frame;
        public GererInterventionsAdd(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;

            frmGerer.Navigate(new GererPrestataireForm());
        }

        private void frmGerer_Navigated(object sender, NavigationEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.frame.Navigate(new GererPrestataireAdd(frame));
        }
    }
}
