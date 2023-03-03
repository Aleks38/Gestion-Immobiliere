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
using WPF_Exo.Views.Detail.Prestataires;
using WPF_Exo.Views.Details;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Prestataires
{
    /// <summary>
    /// Logique d'interaction pour ListPrestatairesView.xaml
    /// </summary>
    public partial class ListPrestatairesView : Page
    {
        public ListPrestatairesView()
        {
            InitializeComponent();

            ImoContext ctx = ImoContext.getInstance();

            foreach (Prestataire prestataire in ctx.Prestataires)
            {
                this.listViewPrestataires.Items.Add(prestataire);
            }
        }

        private void listViewPrestataire_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Prestataire prestataire = (Prestataire)(sender as ListBox).SelectedItem;
            if (prestataire != null)
            {
                PrestataireAfficherDetail prestataireDetail = new PrestataireAfficherDetail(prestataire);

                //this.bienRightFrame.Navigate(bienDetail);
            }
        }
    }
}
