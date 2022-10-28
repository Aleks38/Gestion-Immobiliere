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
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;
using WPF_TP.Views.SubViews;

namespace WPF_TP.Views
{
    /// <summary>
    /// Logique d'interaction pour BienView.xaml
    /// </summary>
    public partial class BienView : Page
    {
        public BienView()
        {
            InitializeComponent();
            this.frmListBien.Navigate(new ListBienView());
            this.frmGererBien.Navigate(new GererBienForm());
        }

        private void frmListBien_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void frmAddBien_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
