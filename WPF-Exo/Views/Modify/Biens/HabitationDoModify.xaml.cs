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
using WPF_TP.Data.Models;

namespace WPF_Exo.Views.Details.Modify
{
    /// <summary>
    /// Logique d'interaction pour HabitationDoModify.xaml
    /// </summary>
    public partial class HabitationDoModify : Page
    {
        public HabitationDoModify(Habitations habitation)
        {
            InitializeComponent();
            BienDoModify bienModify = new BienDoModify(habitation);
            this.FrmBienAfficherModif.Navigate(bienModify);

            txtNbrPiece.Text = habitation.NbPiece.ToString();
            txtNbrChambre.Text = habitation.NbChambre.ToString();
            txtNbrCave.Text = habitation.Cave.ToString();
            txtNbrParking.Text = habitation.Parking.ToString();

        }

        private void FrmBienAfficherModif_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}