using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();

            var theBien = cmbBoxNomBien.SelectedItem;

            Biens unBien = ctx.Biens.Where(r => r.Nom == theBien).FirstOrDefault();

            int apport = int.Parse(txtBxApport.Text);
            int mensualite = int.Parse(txtBxMensualite.Text);
            int duree = int.Parse(txtBxDuree.Text);
            DateTime dateDebut = DateTime.Now;

            Pret thePret = new Pret(apport, mensualite, duree, dateDebut);

            unBien.Pret = new Pret(apport, mensualite, duree, dateDebut);
            ctx.Pret.Add(thePret);

            ctx.SaveChanges();
        }
    }
}
