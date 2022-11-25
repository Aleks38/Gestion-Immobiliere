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
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour GererAppartementForm.xaml
    /// </summary>
    public partial class GererAppartementForm : Page, IObservable
    {
        public GererAppartementForm()
        {
            InitializeComponent();
            this.Observers = new List<IObserver>();
        }
        public List<IObserver> Observers { get; set; }

        private void btnAjouterAppartement_Click_1(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = new ImoContext();

            string nom = txtBxNom.Text;
            int valeur = int.Parse(txtBxValeur.Text);
            string adresse = txtBxAdresse.Text;
            int surface = int.Parse(txtBxSurface.Text);
            int nbPiece = int.Parse(txtBxNbPiece.Text);
            int nbChambre = int.Parse(txtBxNbChambre.Text);
            int cave = int.Parse(txtBxCave.Text);
            int parking = int.Parse(txtBxParking.Text);
            int etage = int.Parse(txtBxEtage.Text);
            bool ascenseur = false;
            bool chauffage = false;


            if (cmbBoxAscenseur.SelectedIndex == 0)
            {
                ascenseur = true;
            }

            if (cmbBoxChauffage.SelectedIndex == 0)
            {
                chauffage = true;
            }

            ctx.Biens.Add(new Appartement(nom, adresse, valeur, surface, nbPiece, nbChambre, cave, parking, etage, ascenseur, chauffage));
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
