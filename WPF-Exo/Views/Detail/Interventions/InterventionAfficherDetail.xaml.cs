using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPF_Exo.Views.Modify.Interventions;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Interventions
{
    /// <summary>
    /// Logique d'interaction pour InterventionAfficherDetail.xaml
    /// </summary>
    public partial class InterventionAfficherDetail : Page, IObservable
    {
        Frame frmGerer;
        Intervention theIntervention;
        public IObserver obs;
        public List<IObserver> Observers { get; set; }
        public InterventionAfficherDetail(Intervention theIntervention, Frame Gerer)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            this.frmGerer = Gerer;
            this.theIntervention = theIntervention;
            this.obs = obs;
            this.Observers = new List<IObserver>();

            if (this.obs != null)
            {
                Observers.Add(obs);
            }

            Biens theBien = ctx.Biens.Find(theIntervention.BienId);
            lblNomBien.Content = theBien.Nom;

            ImoContext ctx2 = new ImoContext();
            Prestataire thePrestataire = ctx2.Prestataires.Find(theIntervention.ListPrestaId[theIntervention.ListPrestaId.Count - 1]);
            lblNomPresta.Content = thePrestataire.Nom;

            lblDate.Content = theIntervention.DateIntervention;
            lblMontant.Content = theIntervention.MontantTTC;
            lblInformation.Content = theIntervention.Information;
        }

        private void btnModifier_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.frmGerer.Navigate(new InterventionDoModify(theIntervention));
        }

        private void btnSupprimer_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer cette intervntion ?",
                    "Supprimer cette intervention",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImoContext ctx = ImoContext.getInstance();
                Intervention intervention = ctx.Intervention.Find(theIntervention.InterventionId);
                Biens bien = ctx.Biens.Where(b => b.BiensId == intervention.BienId).FirstOrDefault();
                ctx.Intervention.Remove(intervention);
                ctx.SaveChanges();
                this.notifyObservers();

                MessageBox.Show("L'intervention faite le " + intervention.DateIntervention + " dans " + bien.Nom);
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
