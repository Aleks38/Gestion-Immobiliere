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

namespace WPF_Exo.Views.Subviews.Pret
{
    /// <summary>
    /// Logique d'interaction pour ListPretsView.xaml
    /// </summary>
    public partial class ListPretsView : Page
    {
        private class ListPretRow
        {
            String NomBien { get; set; }
            int Mensualite { get; set; }
            int Montant { get; set; }
            public int PretId { get; set; }


            public ListPretRow(String NomBien, int Mensualite, int Montant, int PretId)
            {
                this.NomBien = NomBien;
                this.Mensualite = Mensualite;
                this.Montant = Montant;
                this.PretId = PretId;

            }
        }
        public ListPretsView()
        {
            InitializeComponent();

            WPF_TP.Data.Models.Pret unPret = new WPF_TP.Data.Models.Pret();

            ImoContext ctx = ImoContext.getInstance();

            //foreach (Prets unPret in ctx.Prets)
            //{
            //    unPret.Bi
            //}
        }

        private void listViewInterventions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
