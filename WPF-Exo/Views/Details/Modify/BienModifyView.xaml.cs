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

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour BienModifyView.xaml
    /// </summary>
    public partial class BienModifyView : Page
    {
        public int IdBien { get; set; }
        public BienModifyView(int idBien)
        {
            InitializeComponent();

            IdBien = idBien;
            ImoContext ctx = ImoContext.getInstance();
            Biens bien = ctx.Biens.Find(IdBien);

            if (bien is Box)
            {
                this.frmModifyBien.Navigate(new BoxDoModify((Box)bien));
            }
            else if (bien is Appartement)
            {
                this.frmModifyBien.Navigate(new AppartementDoModify((Appartement)bien));
            }
            else if (bien is Maison)
            {
                this.frmModifyBien.Navigate(new MaisonDoModify((Maison)bien));
            }
            
        }

        private void frmModifyBien_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnModifier(object sender, RoutedEventArgs e)
        {

        }
    }
}
