using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Forms.Interventions
{
    /// <summary>
    /// Logique d'interaction pour GererInterventionsForm.xaml
    /// 
    /// </summary>
    public partial class GererInterventionsForm : Page, IObservable
    {
        public InterventionsView interventions;
        public List<IObserver> Observers { get; set; }

        public GererInterventionsForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();


            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                cmbBoxNomBien.Items.Add(bien);
            }

            foreach (Prestataire prestataire in ctx.Prestataires)
            {
                cmbBoxNomPresta.Items.Add(prestataire);
            }
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string dateIntervention = txtBxDate.Text;
            int montantTTC = int.Parse(txtBxMontant.Text);
            string information = txtBxInformation.Text;
            Biens theBien = (Biens)cmbBoxNomBien.SelectedItem;
            Prestataire thePrestaire = (Prestataire)cmbBoxNomPresta.SelectedItem;

            List<int> listPresta = new List<int>();
            listPresta.Add(thePrestaire.PrestataireId);


            ImoContext ctx = new ImoContext();
            ctx.Intervention.Add(new Intervention(dateIntervention, montantTTC, information, listPresta, theBien.BiensId));
            ctx.SaveChanges();
            this.notifyObservers();

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
