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
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Views.SubViews;

namespace WPF_Exo.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour GererBienForm.xaml
    /// </summary>
    public partial class GererBienForm : Page
    {
        private IObserver obs;

        public GererBienForm()
        {
            InitializeComponent();
        }

        private void cmbBoxTypeBien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImoContext ctx = new ImoContext();
            if (cmbBoxTypeBien.SelectedIndex == 0)
            {
                initAjouterBox();
            }
            else if (cmbBoxTypeBien.SelectedIndex == 1)
            {
                initAjouterMaison();
            }
            else if (cmbBoxTypeBien.SelectedIndex == 2)
            {
                initAjouterAppartement();
            }
        }

        private void frmTypeBien_Navigated(object sender, NavigationEventArgs e)
        {

        }
        public GererBienForm(IObserver obs)
        {
            InitializeComponent();
            this.obs = obs;

        }
        private void initAjouterBox()
        {
            GererBoxForm boxForm = new GererBoxForm();
            if (this.obs != null)
            {
                boxForm.Observers.Add(this.obs);

            }
            this.frmTypeBien.Navigate(boxForm);
        }
        private void initAjouterAppartement()
        {
            GererAppartementForm appartementForm = new GererAppartementForm();
            if (this.obs != null)
            {
                appartementForm.Observers.Add(this.obs);

            }
            this.frmTypeBien.Navigate(appartementForm);
        }
        private void initAjouterMaison()
        {
            GererMaisonForm maisonForm = new GererMaisonForm();
            if (this.obs != null)
            {
                maisonForm.Observers.Add(this.obs);

            } 
            this.frmTypeBien.Navigate(maisonForm);
        }
    }
}