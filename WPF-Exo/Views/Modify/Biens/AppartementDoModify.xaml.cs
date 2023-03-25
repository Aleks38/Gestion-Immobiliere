using System;
using System.Windows;
using System.Windows.Controls;
using WPF_Exo.Data.Models;
using WPF_TP.Data.DAL;

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour AppartementDoModify.xaml
    /// </summary>
    public partial class AppartementDoModify : Page
    {
        Appartement theAppartement;
        HabitationDoModify habitationDoModify;
        public AppartementDoModify(Appartement theAppartement)
        {
            InitializeComponent();
            this.theAppartement = theAppartement;
            this.habitationDoModify = new HabitationDoModify(theAppartement);

            txtEtage.Text = theAppartement.Etage.ToString();
            if (theAppartement.Ascenseur)
            {
                cmbAsc.SelectedIndex = 0;

            } else if (theAppartement.Ascenseur == false) 
            {
                cmbAsc.SelectedIndex = 1; 
            }

            if (theAppartement.Chauffage)
            {
                cmbChauffage.SelectedIndex = 0;
            } else if (theAppartement.Chauffage == false)
            {
                cmbChauffage.SelectedIndex = 1;
            }
            
            FrmBoxModify.Navigate(habitationDoModify);
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();

            validate();

            ctx.SaveChanges();
        }

        public void validate()
        {
            this.theAppartement.Etage = int.Parse(txtEtage.Text);
            this.theAppartement.Ascenseur = false;
            this.theAppartement.Chauffage = false;

            if (cmbAsc.SelectedIndex == 0)
            {
                this.theAppartement.Ascenseur = true;
            }

            if (cmbChauffage.SelectedIndex == 0)
            {
                this.theAppartement.Chauffage = true;
            }

            this.habitationDoModify.validate();
            Console.WriteLine(this.theAppartement);
        }
    }
}
