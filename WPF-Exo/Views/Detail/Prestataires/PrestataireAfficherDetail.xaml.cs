using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WPF_Exo.Migrations;
using WPF_Exo.Views.Modify.Prestataires;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour PrestataireAfficherDetail.xaml
    /// </summary>
    public partial class PrestataireAfficherDetail : Page, IObservable
    {
        Frame frmGerer;
        Prestataire prestataire;
        private IObserver obs;
        public List<IObserver> Observers { get; set; }
        public PrestataireAfficherDetail(Prestataire prestataire, Frame frmGerer)
        {
            InitializeComponent();
            this.frmGerer = frmGerer;
            this.prestataire = prestataire;
            this.Observers = new List<IObserver>();

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

        private void btnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce Prestataire ?",
                    "Supprimer prestataire",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImoContext ctx = ImoContext.getInstance();
                Prestataire thePrestataire = ctx.Prestataires.Find(prestataire.PrestataireId);
                ctx.Prestataires.Remove(thePrestataire);
                ctx.SaveChanges();
                this.notifyObservers();

                MessageBox.Show("Le prestataire " + thePrestataire.Nom + " " + thePrestataire.Prenom + " a bien été suprimé.");
            }
        }
        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
