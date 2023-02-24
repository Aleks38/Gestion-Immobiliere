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
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Interventions
{
    /// <summary>
    /// Logique d'interaction pour ListInterventionsView.xaml
    /// </summary>
    public partial class ListInterventionsView : Page
    {
        public ListInterventionsView()
        {
            InitializeComponent();

            //ImoContext ctx = ImoContext.getInstance();

            //foreach (Biens bien in ctx.Biens)
            //{
            //    this.listViewInterventions.Items.Add(bien);
            //}

            //this.bienRightFrame = bienRightFrame;
        }

        private void listViewInterventions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listViewInterventions_DoubleClick(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
