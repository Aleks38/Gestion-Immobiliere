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
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour AppartementDoModify.xaml
    /// </summary>
    public partial class AppartementDoModify : Page
    {
        public AppartementDoModify(Appartement appartement)
        {
            InitializeComponent();

            HabitationDoModify habitationModify = new HabitationDoModify(appartement);
            FrmBoxModify.Navigate(habitationModify);
        }
    }
}
