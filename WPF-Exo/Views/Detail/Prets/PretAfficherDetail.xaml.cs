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
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Prets
{
    /// <summary>
    /// Logique d'interaction pour PretAfficherDetail.xaml
    /// </summary>
    public partial class PretAfficherDetail : Page
    {
        public PretAfficherDetail(WPF_TP.Data.Models.Pret thePret)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();

            Biens theBien = ctx.Biens.Where(b => b.Pret.PretId == thePret.PretId).FirstOrDefault();

            lblNomBien.Content = theBien.Nom;
            lblApport.Content = thePret.Apport;
            lblMensualite.Content = thePret.Mensualite;
            lblDuree.Content = thePret.Duree;
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
