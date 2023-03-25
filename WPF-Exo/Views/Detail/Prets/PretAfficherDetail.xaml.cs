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
using WPF_Exo.Migrations;
using WPF_Exo.Views.Modify.Prets;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Detail.Prets
{
    /// <summary>
    /// Logique d'interaction pour PretAfficherDetail.xaml
    /// </summary>
    public partial class PretAfficherDetail : Page, IObservable
    {
        Frame frmGerer;
        Pret thePret;
        private IObserver obs;
        public List<IObserver> Observers { get; set; }
        public PretAfficherDetail(Pret thePret, Frame frmGerer, IObserver obs)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            this.frmGerer = frmGerer;
            this.thePret = thePret;
            this.obs = obs;
            this.Observers = new List<IObserver>();

            if (this.obs != null)
            {
                Observers.Add(obs);
            }

            Biens theBien = ctx.Biens.Where(b => b.Pret.PretId == thePret.PretId).FirstOrDefault();

            lblNomBien.Content = theBien.Nom;
            lblApport.Content = thePret.Apport;
            lblMensualite.Content = thePret.Mensualite;
            lblDuree.Content = thePret.Duree;
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce pret ?",
                    "Supprimer pret",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImoContext ctx = ImoContext.getInstance();
                Pret pret = ctx.Pret.Find(thePret.PretId);
                Biens bien = ctx.Biens.Where(b => b.Pret.PretId == pret.PretId).FirstOrDefault();
                ctx.Pret.Remove(pret);
                ctx.SaveChanges();
                this.notifyObservers();

                MessageBox.Show("Le pret pour " + bien.Nom + " a bien été supprimé");
            }
        }

        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            this.frmGerer.Navigate(new PretDoModify(thePret));
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
