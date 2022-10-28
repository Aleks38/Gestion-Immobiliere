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
using WPF_TP.Data.DAL;

namespace WPF_Exo.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour GererBienForm.xaml
    /// </summary>
    public partial class GererBienForm : Page
    {
        public GererBienForm()
        {
            InitializeComponent();
        }
        private void cmbBoxTypeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImoContext ctx = new ImoContext();
            if (cmbBoxTypeBien.SelectedIndex == 0)
            {
                this.frmTypeBien.Navigate(new GererBoxForm());
            }
            else if (cmbBoxTypeBien.SelectedIndex == 1)
            {
                this.frmTypeBien.Navigate(new GererMaisonForm());
            }
            else if (cmbBoxTypeBien.SelectedIndex == 2)
            {
                this.frmTypeBien.Navigate(new GererAppartementForm());
            }
        }

        private void frmTypeBien_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
