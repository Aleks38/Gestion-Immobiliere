using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;
using WPF_TP.Views;

namespace WPF_Exo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new NavigationView();

            // ligne à ajouter pour la compatibilité des dates
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            ImoContext ctx = new ImoContext();
            Appartement unAppartement = new Appartement("Loft", "1 passage des soubisses", 400000, 150, 8, 4, 1, 1, 5, true, true);
            Locataire unLocataire = new Locataire("Montana", "Tony", 52, "Dealer");
            List<Locataire> listLocataire = new List<Locataire>();
            listLocataire.Add(unLocataire);
            ctx.Prets.Add(new Pret(20000, 1000, 240, new DateTime(2015, 07, 23), unAppartement));
            ctx.Contrats.Add(new Contrat(1200, "2015, 09, 01", "2020, 09, 01", listLocataire, unAppartement));
            ctx.SaveChanges();
        }
    }
}
