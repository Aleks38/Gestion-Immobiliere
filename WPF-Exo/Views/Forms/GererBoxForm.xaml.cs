﻿using System;
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
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Subviews
{
    /// <summary>
    /// Logique d'interaction pour GererBoxForm.xaml
    /// </summary>
    public partial class GererBoxForm : Page
    {
        public GererBoxForm()
        {
            InitializeComponent();
        }

        private void btnAjouterBox_Click(object sender, RoutedEventArgs e)
        {
            ImoContext ctx = new ImoContext();

            string nom = txtBxNom.Text;
            int valeur = int.Parse(txtBxValeur.Text);
            string adresse = txtBxAdresse.Text;
            int surface = int.Parse(txtBxSurface.Text);

            ctx.Biens.Add(new Box(nom, adresse, valeur, surface));
            ctx.SaveChanges();
        }
    }
}
