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
    /// Logique d'interaction pour AppartementAffciherDetail.xaml
    /// </summary>
    public partial class AppartementAffciherDetail : Page
    {
        public AppartementAffciherDetail()
        {
            InitializeComponent();
            HabitationAfficherDetail habitattionDetail = new HabitationAfficherDetail();
            this.FrmHabitableAfficherDetail.Navigate(habitattionDetail);
        }

        private void FrmHabitableAfficherDetail_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
