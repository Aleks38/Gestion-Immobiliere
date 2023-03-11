using System.Windows.Controls;
using WPF_Exo.Views.Modify.Prestataires;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour PrestataireAfficherDetail.xaml
    /// </summary>
    public partial class PrestataireAfficherDetail : Page
    {
        Frame frmGerer;
        Prestataire prestataire;
        public PrestataireAfficherDetail(Prestataire prestataire, Frame frmGerer)
        {
            InitializeComponent();
            this.frmGerer = frmGerer;
            this.prestataire = prestataire;

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

        private void btnModifier_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.frmGerer.Navigate(new PrestataireDoModify(prestataire));
        }
    }
}
