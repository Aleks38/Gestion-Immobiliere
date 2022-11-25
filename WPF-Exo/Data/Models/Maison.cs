using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    class Maison : Habitations
    {
        public Maison(string nom, string adresse, int valeur, int surface, int nbPiece, int nbChambre, int cave, int parking)
            : base(nom, adresse, valeur, surface, nbPiece, nbChambre, cave, parking)
        {

        }
        public int MaisonId { get; set; }
        public override void afficher()
        {
            base.afficher();
        }
    }
}
