using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour BoxDoModify.xaml
    /// </summary>
    public partial class BoxDoModify : Page
    {
        Box box;
        BienDoModify bienModify;
        public BoxDoModify(Box box)
        {
            InitializeComponent();
            this.box = box;

            bienModify = new BienDoModify(box);
            FrmBoxModify.Navigate(bienModify);
            
        }

        private void FrmBoxModify_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnModifier(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();

            this.bienModify.validate();

            Console.WriteLine(this.box);
            ctx.SaveChanges();
        }
    }
}
