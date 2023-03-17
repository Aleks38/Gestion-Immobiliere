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
using WPF_Exo.Views.Forms.Interventions;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Interventions
{
    /// <summary>
    /// Logique d'interaction pour ListInterventionsView.xaml
    /// </summary>
    public partial class ListInterventionsView : Page
    {

        public class ListInterventionRow
        {
            public String NomBien { get; set; }
            public String RaisonSocialePrestataire { get; set; }
            public String DateIntervention { get; set; }
            public int InterventionId { get; set; }


            public ListInterventionRow(String NomBien, String RaisonSocialePrestataire, String DateIntervention, int InterventionId)
            {
                this.NomBien = NomBien;
                this.RaisonSocialePrestataire = RaisonSocialePrestataire;
                this.DateIntervention = DateIntervention;
                this.InterventionId = InterventionId;

            }
        }

        public Frame frmGerer;
        public Frame frmList;
        public ListInterventionsView(Frame frmGerer, Frame frmList)
        {
            InitializeComponent();
            this.frmGerer = frmGerer;
            this.frmList = frmList;
            ImoContext ctx = ImoContext.getInstance();

            foreach (Intervention intervention in ctx.Intervention)
            {
                ImoContext ctx2 = new ImoContext();
                Biens unBiens = ctx2.Biens.Find(intervention.BienId);

                foreach (int prestataireId in intervention.ListPrestaId)
                {
                    ImoContext ctx3 = new ImoContext();
                    Prestataire prestataire = ctx3.Prestataires.Find(prestataireId);

                    ListInterventionRow interventionRow = new ListInterventionRow(unBiens.Nom, prestataire.RaisonSociale, intervention.DateIntervention, intervention.InterventionId);
                    this.listViewInterventions.Items.Add(interventionRow);
                }
            }
            //this.refreshList();
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
            ListInterventionRow listIntervention = (ListInterventionRow)(sender as ListBox).SelectedItem;
            if (listIntervention != null)
            {
                ImoContext ctx = ImoContext.getInstance();
                Intervention theIntervention = ctx.Intervention.Find(listIntervention.InterventionId);

                GererPrestataireAdd prestataireAdd = new GererPrestataireAdd(frmList, frmGerer, theIntervention);
                frmGerer.Navigate(prestataireAdd);
            }
            
        }

        private void listViewInterventions_DoubleClick(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
