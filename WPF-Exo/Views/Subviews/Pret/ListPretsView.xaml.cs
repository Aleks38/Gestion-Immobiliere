using System;
using System.Linq;
using System.Windows.Controls;
using WPF_Exo.Views.Detail.Prets;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews.Pret
{
    /// <summary>
    /// Logique d'interaction pour ListPretsView.xaml
    /// </summary>
    public partial class ListPretsView : Page, IObserver
    {
        private class ListPretRow
        {
            public String? NomBien { get; set; }
            public int? Mensualite { get; set; }
            public int? Montant { get; set; }
            public int? PretId { get; set; }


            public ListPretRow(String? NomBien, int? Mensualite, int? Montant, int? PretId)
            {
                this.NomBien = NomBien;
                this.Mensualite = Mensualite;
                this.Montant = Montant;
                this.PretId = PretId;

            }
        }

        public Frame frmGerer;
        public ListPretsView(Frame frmGerer)
        {
            InitializeComponent();
            this.frmGerer = frmGerer;

            refreshList();
        }

        private void listViewPret_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();
            ListPretRow pretRow = (ListPretRow)(sender as ListBox).SelectedItem;

            if (pretRow != null)
            {
                WPF_TP.Data.Models.Pret thePret = ctx.Pret.Where(b => b.PretId == pretRow.PretId).FirstOrDefault();
                frmGerer.Navigate(new PretAfficherDetail(thePret, frmGerer, this));
            }
        }
        private void refreshList()
        {
            ImoContext ctx = ImoContext.getInstance();

            this.listViewPret.Items.Clear();

            foreach (WPF_TP.Data.Models.Pret pret in ctx.Pret)
            {
                ImoContext ctx2 = new ImoContext();

                Biens theBien = ctx2.Biens.Where(b => b.Pret.PretId == pret.PretId).FirstOrDefault();
                if (theBien != null)
                {
                    ListPretRow theListPret = new ListPretRow(theBien.Nom, pret.Mensualite, theBien.Valeur, pret.PretId);
                    this.listViewPret.Items.Add(theListPret);
                }
            }
        }
        public void update()
        {
            this.refreshList();
        }
    }
}
