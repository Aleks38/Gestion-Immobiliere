using System.Windows.Controls;
using System.Windows.Input;
using WPF_Exo.Views.Details;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_TP.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page, IObserver
    {
        private Frame bienRightFrame;

        public ListBienView(Frame bienRightFrame)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                this.listViewBiens.Items.Add(bien);
            }

            this.bienRightFrame = bienRightFrame;
        }
        private void listViewBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();

            Biens theBien = (Biens)(sender as ListBox).SelectedItem;

            bienDetail(theBien.BiensId);

        }

        public void chargerViewParId(int id)
        {
            ImoContext ctx = ImoContext.getInstance();
            bool place = false;
            Biens bien = ctx.Biens.Find(id);

        }
        public void listViewDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        private void bienDetail(int idBien)
        {
            ListBienView bienView = new ListBienView(bienRightFrame);
            BienDetailView bienDetail = new BienDetailView(idBien, bienView);

            this.bienRightFrame.Navigate(bienDetail);
        }
        private void refreshList()
        {
            ImoContext ctx = ImoContext.getInstance();

            foreach (Biens bien in ctx.Biens)
            {
                this.listViewBiens.Items.Add(bien);
            }
        }
        public void update()
        {
            this.refreshList();
        }
    }
}
