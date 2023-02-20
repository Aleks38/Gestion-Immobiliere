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
using WPF_Exo.Data.Models;
using WPF_Exo.Views.Subviews;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details
{
    /// <summary>
    /// Logique d'interaction pour BienDetailView.xaml
    /// </summary>
    public partial class BienDetailView : Page, IObservable
    {
        public int IdBien { get; set; }
        private IObserver obs;

        public BienDetailView(int idBien, IObserver obs)
        {
            
            InitializeComponent();
            this.obs = obs;
            this.Observers = new List<IObserver>();

            if (this.obs != null)
            {
                Observers.Add(obs);
            }

            IdBien = idBien;
            ImoContext ctx = ImoContext.getInstance();
            Biens bien = ctx.Biens.Find(IdBien);

            if (bien is Box)
            {
                this.frmDetailBien.Navigate(new BoxAfficherDetail((Box)bien));
            }
            else if (bien is Appartement)
            {
                this.frmDetailBien.Navigate(new AppartementAffciherDetail((Appartement)bien));
            }
            else if (bien is Maison)
            {
                this.frmDetailBien.Navigate(new MaisonAfficherDetail((Maison)bien));
            }
   
        }
        public List<IObserver> Observers { get; set; }

        private void frmDetailBien_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnModifier(object sender, RoutedEventArgs e)
        {

        }

        private void btnSupp(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce bien ?",
                    "Supprimer bien",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ImoContext ctx = ImoContext.getInstance();
                Biens bien = ctx.Biens.Find(IdBien);
                ctx.Biens.Remove(bien);
                ctx.SaveChanges();
                this.notifyObservers();

                MessageBox.Show("Le bien " + bien.Nom + " a bien été suprimé.");
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
