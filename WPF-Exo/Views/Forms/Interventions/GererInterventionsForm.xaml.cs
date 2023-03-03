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
                cmbBoxNomBien.Items.Add(bien.Nom);
            }

            foreach (Prestataire prestataire in ctx.Prestataires)
            {
                cmbBoxNomPresta.Items.Add(prestataire.Nom);
            }
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            string dateIntervention = txtBxDate.Text;
            int montantTTC = int.Parse(txtBxMontant.Text);
            string information = txtBxInformation.Text;

            List<Prestataire> listPresta = new List<Prestataire>();
            //Biens unBien =  ;
            //Intervention addIntervention = new Intervention(dateIntervention, montantTTC, information, listPresta, unBien);
            ImoContext ctx = new ImoContext();
            //ctx.Intervention.Add(addIntervention);
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
