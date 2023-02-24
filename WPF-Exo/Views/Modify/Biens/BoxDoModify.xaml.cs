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
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour BoxDoModify.xaml
    /// </summary>
    public partial class BoxDoModify : Page
    {
        public BoxDoModify(Box box)
        {
            InitializeComponent();

            BienDoModify bienModify = new BienDoModify(box);
            FrmBoxModify.Navigate(bienModify);
        }

        private void FrmBoxModify_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
