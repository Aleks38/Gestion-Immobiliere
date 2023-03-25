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
using WPF_TP.Data.DAL;
using WPF_TP.Data.DAO;
using WPF_TP.Data.Models;

namespace WPF_TP.Views
{
    /// <summary>
    /// Logique d'interaction pour HomeView.xaml
    /// </summary>
    public partial class HomeView : Page
    {
        DAOBien DAO;
        public HomeView()
        {
            InitializeComponent();
            this.DAO = new DAOBien();

            lblNbrBien.Content = DAO.findBiens().Count();

            lblNbrPret.Content = DAO.findPret().Count();

            lblNbrDette.Content = DAO.detteMensuel() + " €";
        }
    }
}
