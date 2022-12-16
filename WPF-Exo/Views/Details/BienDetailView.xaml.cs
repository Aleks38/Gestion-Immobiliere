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

namespace WPF_Exo.Views.Details
{
    /// <summary>
    /// Logique d'interaction pour BienDetailView.xaml
    /// </summary>
    public partial class BienDetailView : Page
    {
        public BienDetailView(int idBien)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            Biens bien = ctx.Biens.Find(idBien);

            if (bien is Box)
            {
                this.frmDetailBien.Navigate(new BoxAfficherDetail((Box)bien));
            }
            else if (bien is Appartement)
            {
                this.frmDetailBien.Navigate(new AppartementAffciherDetail((Appartement)bien));
            }
            else if (bien is Maison)
            {
                this.frmDetailBien.Navigate(new MaisonAfficherDetail((Maison)bien));
            }
        }

        private void frmDetailBien_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
