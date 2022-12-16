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
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details
{
    /// <summary>
    /// Logique d'interaction pour BienAfficherDetail.xaml
    /// </summary>
    public partial class BienAfficherDetail : Page
    {
        public BienAfficherDetail(Biens bien)
        {
            InitializeComponent();
            this.lblNom.Content = bien.Nom;
            this.lblAdresse.Content = bien.Adresse;
            this.lblSurface.Content = bien.Surface;
            this.lblValeur.Content = bien.Valeur;
        }
    }
}
