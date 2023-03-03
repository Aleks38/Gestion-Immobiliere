using System.Windows.Controls;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour PrestataireAfficherDetail.xaml
    /// </summary>
    public partial class PrestataireAfficherDetail : Page
    {
        public PrestataireAfficherDetail(Prestataire prestataire)
        {
            InitializeComponent();
            lblRaisonSoc.Content = prestataire.RaisonSociale;
            lblNom.Content = prestataire.Nom;
            lblPrenom.Content = prestataire.Prenom;
            lblTelephone.Content = prestataire.Telephone;
            lblAdresse.Content = prestataire.Adresse;
        }

        public PrestataireAfficherDetail()
        {
            InitializeComponent();
        }
    }
}
