using Microsoft.EntityFrameworkCore;
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
using WPF_Exo.Views.Details;
using WPF_Exo.Views.Subviews;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_TP.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page, IObserver
    {
        private Frame bienRightFrame;

        public ListBienView(Frame bienRightFrame)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                this.listViewBiens.Items.Add(bien.Nom);
            }

            this.bienRightFrame = bienRightFrame;
        }
        private void listViewBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();

            string nomBien = (string)(sender as ListBox).SelectedItem;

            var result = from a in ctx.Biens
                          where a.Nom == nomBien
                          select a.BiensId;

            List<int> list;

            list = result.ToList();

            foreach (int bien in list)
            {
                string test = bien.ToString();
                MessageBox.Show(test);
            }

            
        }
        public void listViewDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AppartementAffciherDetail appartementDetail = new AppartementAffciherDetail();
            this.bienRightFrame.Navigate(appartementDetail);
        }
        private void refreshList()
        {
            ImoContext ctx = ImoContext.getInstance();

            this.listViewBiens.Items.Clear();

            foreach (Biens bien in ctx.Biens)
            {
                this.listViewBiens.Items.Add(bien.Nom);
            }
        }
        public void update()
        {
            this.refreshList();
        }
    }
}
