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
using WPF_Exo.Views.Subviews.Interventions;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Forms.Interventions
{
    /// <summary>
    /// Logique d'interaction pour GererPrestataireForm.xaml
    /// </summary>
    public partial class GererPrestataireForm : Page, IObservable
    {
        public List<IObserver> Observers { get; set; }

        public GererPrestataireForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string raisonSociale = txtBxRaisonSoc.Text;
            string nom = txtBxNom.Text;
            string prenom = txtBxPrenom.Text;
            string telephone = txtBxTelephone.Text;
            string adresse = txtBxAdresse.Text;
            List<Intervention> listIntervention = new List<Intervention>();

            Prestataire prestataire = new Prestataire(raisonSociale, nom, prenom, telephone, adresse, listIntervention);
            ImoContext ctx = new ImoContext();
            ctx.Prestataires.Add(prestataire);
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
