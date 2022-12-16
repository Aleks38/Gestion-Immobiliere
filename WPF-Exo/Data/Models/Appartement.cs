using System;
using System.Collections.Generic;
using System.Text;
using WPF_TP.Data.Models;

namespace WPF_Exo.Data.Models
{
    public class Appartement : Habitations
    {
        private int etage;
        private bool ascenseur;
        private bool chauffage;
        public Appartement(string nom, string adresse, int valeur, int surface, int nbPiece, int nbChambre, int cave, int parking, int etage, bool ascenseur, bool chauffage)
            :base(nom, adresse, valeur, surface, nbPiece, nbChambre, cave, parking)
        {
            Etage = etage;
            Ascenseur = ascenseur;
            Chauffage = chauffage;
        }
        public int AppartmentId { get; set; }
        public int Etage { get => etage; set => etage = value; }
        public bool Ascenseur { get => ascenseur; set => ascenseur = value; }
        public bool Chauffage { get => chauffage; set => chauffage = value; }

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Numéro étage : " + Etage);
            Console.WriteLine("Assenceur : " + Ascenseur);
            Console.WriteLine("Chauffage commun : " + Chauffage);
        }
    }
}
