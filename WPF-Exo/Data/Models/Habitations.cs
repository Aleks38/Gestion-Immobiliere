using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Habitations : Biens
    {
        private int nbPiece;
        private int nbChambre;
        private int cave;
        private int parking;

        public Habitations(string nom, string adresse, int valeur, int surface, int nbPiece, int nbChambre, int cave, int parking)
            :base(nom, adresse, valeur, surface)
        {
            this.nbPiece = nbPiece;
            this.nbChambre = nbChambre;
            this.cave = cave;
            this.parking = parking;
        }
        public int HabitationsId { get; set; }
        public int NbPiece { get => nbPiece; set => nbPiece = value; }
        public int NbChambre { get => nbChambre; set => nbChambre = value; }
        public int Cave { get => cave; set => cave = value; }
        public int Parking { get => parking; set => parking = value; }

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Nombres pièces : " + NbPiece);
            Console.WriteLine("Nombres chambres : " + NbChambre);
            Console.WriteLine("Nombres caves : " + cave);
            Console.WriteLine("Nombres parking : " + parking);
        }
    }
}  
