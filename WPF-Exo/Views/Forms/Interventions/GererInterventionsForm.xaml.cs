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

namespace WPF_Exo.Views.Forms.Interventions
{
    /// <summary>
    /// Logique d'interaction pour GererInterventionsForm.xaml
    /// 
    /// </summary>
    public partial class GererInterventionsForm : Page
    {
        public InterventionsView interventions;
        public GererInterventionsForm()
        {
            InitializeComponent();

            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                cmbBoxNomBien.Items.Add(bien.Nom);
            }

            foreach (Prestataire prestataire in ctx.Prestataires)
            {
                cmbBoxNomPresta.Items.Add(prestataire.Nom);
            }
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
