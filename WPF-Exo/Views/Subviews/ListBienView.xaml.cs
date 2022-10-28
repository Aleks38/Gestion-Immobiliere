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
using WPF_Exo.Views.Subviews;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_TP.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page
    {
        public ListBienView()
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                this.listViewBiens.Items.Add(bien.Nom);
            }

        }

        private void listViewBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void listViewDoubleClick(object sender, MouseButtonEventArgs e)
        {
            BienSingleView objet = new BienSingleView();
            objet.alaide.Text = "prout prout";
        }
    }
}
