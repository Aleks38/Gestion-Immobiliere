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
using WPF_Exo.Views.Modify.Prets;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Prets
{
    /// <summary>
    /// Logique d'interaction pour PretAfficherDetail.xaml
    /// </summary>
    public partial class PretAfficherDetail : Page
    {
        Frame frmGerer;
        Pret thePret;
        public PretAfficherDetail(Pret thePret, Frame frmGerer)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            this.frmGerer = frmGerer;
            this.thePret = thePret;

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
            this.frmGerer.Navigate(new PretDoModify(thePret));
        }
    }
}
