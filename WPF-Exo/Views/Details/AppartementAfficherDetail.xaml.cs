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
using WPF_Exo.Data.Models;

namespace WPF_Exo.Views.Details
{
    /// <summary>
    /// Logique d'interaction pour AppartementAffciherDetail.xaml
    /// </summary>
    public partial class AppartementAfficherDetail : Page
    {
        public AppartementAfficherDetail(Appartement appartement)
        {
            InitializeComponent();
            HabitationAfficherDetail habitattionDetail = new HabitationAfficherDetail(appartement);
            this.FrmHabitableAfficherDetail.Navigate(habitattionDetail);

            lblEtage.Content = appartement.Etage;
            if (appartement.Chauffage == false)
            {
                lblChauffageCommun.Content = "Ne possède pas";
            }
            else if (appartement.Chauffage == true)
            {
                lblChauffageCommun.Content = "Possède";
            }
            if (appartement.Ascenseur == false)
            {
                lblAscenseur.Content = "Ne possède pas";
            }
            else if (appartement.Ascenseur == true)
            {
                lblAscenseur.Content = "Possède";
            }
        }

        private void FrmHabitableAfficherDetail_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
