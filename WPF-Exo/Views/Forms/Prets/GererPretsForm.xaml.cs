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

namespace WPF_Exo.Views.Forms.Prets
{
    /// <summary>
    /// Logique d'interaction pour GererPretsForm.xaml
    /// </summary>
    public partial class GererPretsForm : Page
    {
        public GererPretsForm()
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                cmbBoxNomBien.Items.Add(bien.Nom);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();

            int apport = int.Parse(txtBxApport.Text);
            int mensualite = int.Parse(txtBxMensualite.Text);
            int duree = int.Parse(txtBxDuree.Text);
            DateTime dateDebut = DateTime.Now;
            

            //Pret pret = new Pret(apport, mensualite, duree, dateDebut, unBien);
        }
    }
}
