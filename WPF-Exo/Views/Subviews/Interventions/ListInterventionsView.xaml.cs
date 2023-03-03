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
using WPF_Exo.Views.Detail.Interventions;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Interventions
{
    /// <summary>
    /// Logique d'interaction pour ListInterventionsView.xaml
    /// </summary>
    public partial class ListInterventionsView : Page
    {
        public Frame frmGerer;
        public ListInterventionsView(Frame frmGerer)
        {
            InitializeComponent();

            ImoContext ctx = ImoContext.getInstance();

            foreach (Intervention intervention in ctx.Intervention)
            {
                this.listViewInterventions.Items.Add(intervention);
            }
        }

        private void listViewInterventions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InterventionAfficherDetail interventionDetail = new InterventionAfficherDetail(this.frmGerer);
            this.frmGerer.Navigate(interventionDetail);
        }

        private void listViewInterventions_DoubleClick(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
