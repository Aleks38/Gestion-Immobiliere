using System.Windows.Controls;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Modify.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour PrestataireDoModify.xaml
    /// </summary>
    public partial class PrestataireDoModify : Page
    {
        Prestataire thePrestataire;
        public PrestataireDoModify(Prestataire thePrestataires)
        {
            InitializeComponent();
            this.thePrestataire = thePrestataires;

            txtRaisonSoc.Text = thePrestataires.RaisonSociale;
            txtNom.Text = thePrestataires.Nom;
            txtPrenom.Text = thePrestataires.Prenom;
            txtTelephone.Text = thePrestataires.Telephone;
            txtAdresse.Text = thePrestataires.Adresse;
        }

        private void btnModifier_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.thePrestataire.RaisonSociale = txtRaisonSoc.Text;
            this.thePrestataire.Nom = txtNom.Text;
            this.thePrestataire.Prenom = txtPrenom.Text;
            this.thePrestataire.Telephone = txtTelephone.Text;
            this.thePrestataire.Adresse = txtAdresse.Text;
        }
    }
}
