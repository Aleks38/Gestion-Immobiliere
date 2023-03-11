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

namespace WPF_Exo.Views.Modify.Prets
{
    /// <summary>
    /// Logique d'interaction pour PretDoModify.xaml
    /// </summary>
    public partial class PretDoModify : Page
    {
        public PretDoModify(Pret unPret)
        {
            InitializeComponent();

            txtApport.Text = unPret.Apport.ToString();
            txtMensualite.Text = unPret.Mensualite.ToString();
            txtDuree.Text = unPret.Duree.ToString();
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
