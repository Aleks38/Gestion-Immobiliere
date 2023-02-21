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

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour BienDoModify.xaml
    /// </summary>
    public partial class BienDoModify : Page
    {
        public BienDoModify(Biens bien)
        {
            InitializeComponent();

            txtBoxNom.Text = bien.Nom;
            txtBoxAdresse.Text = bien.Adresse;
            txtBoxSurface.Text = bien.Surface.ToString();
            txtBoxValeur.Text = bien.Valeur.ToString();
        }
    }
}
