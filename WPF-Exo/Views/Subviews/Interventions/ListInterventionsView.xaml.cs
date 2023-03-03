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

        private class ListInterventionRow
        {
            String NomBien { get; set; }
            String RaisonSocialePrestataire { get; set; }
            String DateIntervention { get; set; }
            
            public ListInterventionRow(String NomBien, String RaisonSocialePrestataire, String DateIntervention)
            {
                this.NomBien = NomBien;
                this.RaisonSocialePrestataire = RaisonSocialePrestataire;
                this.DateIntervention = DateIntervention;
            }
        }


        public Frame frmGerer;
        public ListInterventionsView(Frame frmGerer)
        {
            InitializeComponent();
            this.refreshList();
        }

        public void refreshList()
        {
            ImoContext ctx = ImoContext.getInstance();
            ImoContext ctx2 = new ImoContext();

            foreach (Intervention intervention in ctx2.Intervention)
            {
                int bienId = intervention.BienId;
                
                Biens bien = ctx.Biens.Find(bienId);
                //if (bien != null)
                //{
                //    ListInterventionRow row = new ListInterventionRow(bien.Nom, intervention.ListPresta[0].RaisonSociale, intervention.DateIntervention);
                //    this.listViewInterventions.Items.Add(row);
                //}
            }
        }

        private void listViewInterventions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Intervention theIntervention = (Intervention)(sender as ListBox).SelectedItem;
            if (theIntervention != null)
            {
                InterventionAfficherDetail interventionDetail = new InterventionAfficherDetail(theIntervention);
                frmGerer.Navigate(interventionDetail);
            }
            
        }

        private void listViewInterventions_DoubleClick(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
