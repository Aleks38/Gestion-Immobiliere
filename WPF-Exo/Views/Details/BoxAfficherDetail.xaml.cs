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

namespace WPF_Exo.Views.Details
{
    /// <summary>
    /// Logique d'interaction pour BoxAfficherDetail.xaml
    /// </summary>
    public partial class BoxAfficherDetail : Page
    {
        public BoxAfficherDetail()
        {
            InitializeComponent();
            BienAfficherDetail bienDetail = new BienAfficherDetail();
            FrmBienAfficherDetail.Navigate(bienDetail);
        }

        private void FrmBienAfficherDetail_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
