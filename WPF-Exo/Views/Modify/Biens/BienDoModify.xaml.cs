using System.Windows.Controls;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour BienDoModify.xaml
    /// </summary>
    public partial class BienDoModify : Page
    {
        public Biens bien { get; set; }
        public BienDoModify(Biens bien)
        {
            InitializeComponent();
            this.bien = bien;

            txtBoxNom.Text = bien.Nom;
            txtBoxAdresse.Text = bien.Adresse;
            txtBoxSurface.Text = bien.Surface.ToString();
            txtBoxValeur.Text = bien.Valeur.ToString();

        }

        public void validate()
        {
            this.bien.Nom = txtBoxNom.Text;
            this.bien.Adresse = txtBoxAdresse.Text;
            this.bien.Surface = int.Parse(txtBoxSurface.Text);
            this.bien.Valeur = int.Parse(txtBoxValeur.Text);
        }
    }
}
