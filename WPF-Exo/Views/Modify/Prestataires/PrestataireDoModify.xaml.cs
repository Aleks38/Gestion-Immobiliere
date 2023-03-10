using System.Windows.Controls;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Modify.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour PrestataireDoModify.xaml
    /// </summary>
    public partial class PrestataireDoModify : Page
    {
        public PrestataireDoModify(Prestataire thePrestataires)
        {
            InitializeComponent();
            txtRaisonSoc.Text = thePrestataires.RaisonSociale;
            txtNom.Text = thePrestataires.Nom;
            txtPrenom.Text = thePrestataires.Prenom;
            txtTelephone.Text = thePrestataires.Telephone;
            txtAdresse.Text = thePrestataires.Adresse;
        }
    }
}
