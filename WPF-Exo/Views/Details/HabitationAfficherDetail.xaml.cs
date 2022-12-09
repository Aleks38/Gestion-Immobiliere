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
using WPF_Exo.Views.Subviews;

namespace WPF_Exo.Views.Details
{
    /// <summary>
    /// Logique d'interaction pour HabitationAfficherDetail.xaml
    /// </summary>
    public partial class HabitationAfficherDetail : Page
    {
        public HabitationAfficherDetail()
        {
            InitializeComponent();
            BienAfficherDetail bienDetail = new BienAfficherDetail();
            this.FrmBienAfficherDetail.Navigate(bienDetail);

        }

        private void FrmBienAfficherDetail_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
