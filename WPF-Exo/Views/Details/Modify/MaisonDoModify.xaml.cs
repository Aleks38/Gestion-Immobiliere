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
    /// Logique d'interaction pour MaisonDoModify.xaml
    /// </summary>
    public partial class MaisonDoModify : Page
    {
        public MaisonDoModify(Maison maison)
        {
            InitializeComponent();

            HabitationDoModify habitationtionModify = new HabitationDoModify(maison);
            FrmHabitationAfficherModif.Navigate(habitationtionModify);
        }

        private void FrmHabitationAfficherModif_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
