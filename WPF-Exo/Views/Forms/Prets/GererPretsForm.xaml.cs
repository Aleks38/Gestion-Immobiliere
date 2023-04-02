using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPF_Exo.Views.Tools;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Forms.Prets
{
    /// <summary>
    /// Logique d'interaction pour GererPretsForm.xaml
    /// </summary>
    public partial class GererPretsForm : Page, IObservable
    {
        private IObserver obs;
        public List<IObserver> Observers { get; set; }
        public GererPretsForm(IObserver obs)
        {
            InitializeComponent();
            ImoContext ctx = ImoContext.getInstance();
            this.obs = obs;
            this.Observers = new List<IObserver>();

            foreach (Biens bien in ctx.Biens)
            {
                cmbBoxNomBien.Items.Add(bien.Nom);
            }
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = ImoContext.getInstance();
            ImoContext ctx2 = new ImoContext();
            ImoContext ctx3 = new ImoContext();

            var theBien = cmbBoxNomBien.SelectedItem;

            int apport = int.Parse(txtBxApport.Text);
            int mensualite = int.Parse(txtBxMensualite.Text);
            int duree = int.Parse(txtBxDuree.Text);
            DateTime dateDebut = DateTime.Now;
            DateTime utcDateTime = dateDebut.ToUniversalTime();

            Pret thePret = new Pret(apport, mensualite, duree, utcDateTime);
            
            ctx.Pret.Add(thePret);

            ctx.SaveChanges();

            Biens unBien = ctx2.Biens.Where(r => r.Nom == theBien).FirstOrDefault();
            Pret unPret = ctx3.Pret.Where(r => r.DateDebut == utcDateTime).FirstOrDefault();

            unBien.Pret = unPret;

            ctx2.SaveChanges();
            this.notifyObservers();
        }
        void notifyObservers()
        {
            foreach (IObserver obs in Observers)
            {
                obs.update();
            }
        }
    }
}
