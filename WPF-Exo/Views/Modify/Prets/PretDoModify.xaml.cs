using System.Windows;
using System.Windows.Controls;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Modify.Prets
{
    /// <summary>
    /// Logique d'interaction pour PretDoModify.xaml
    /// </summary>
    public partial class PretDoModify : Page
    {
        Pret unPret;
        public PretDoModify(Pret unPret)
        {
            InitializeComponent();
            this.unPret = unPret;

            txtApport.Text = unPret.Apport.ToString();
            txtMensualite.Text = unPret.Mensualite.ToString();
            txtDuree.Text = unPret.Duree.ToString();
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            this.unPret.Apport = int.Parse(txtApport.Text);
            this.unPret.Mensualite = int.Parse(txtMensualite.Text);
            this.unPret.Duree = int.Parse(txtDuree.Text);
        }
    }
}
