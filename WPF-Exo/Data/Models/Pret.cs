using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Pret
    {
        private int apport;
        private int mensualite;
        private int duree;
        private DateTime dateDebut;

        public Pret(int apport, int mensualite, int duree, DateTime dateDebut)
        {
            Apport = apport;
            Mensualite = mensualite;
            Duree = duree;
            DateDebut = dateDebut;
        }
        public Pret()
        {

        }
        public int PretId { get; set; }
        public int Apport { get => apport; set => apport = value; }
        public int Mensualite { get => mensualite; set => mensualite = value; }
        public int Duree { get => duree; set => duree = value; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }

        protected int capitalRestant()
        {
            int prixAppart = apport + mensualite * duree;

            float dateFloat = (float)(DateTime.Now.Subtract(dateDebut).Days / (365.25 / 12));
            int dateInt = (int)dateFloat + 1;

            int dejaPaye = mensualite * dateInt;

            int capital = prixAppart - dejaPaye;
            return capital;
        }

        //fonction pour afficher les détails d'un bien
        public void afficher()
        {
            Console.WriteLine("===Prêt===");
            Console.WriteLine("Apport : " + Apport + " €");
            Console.WriteLine("Mensualité : " + Mensualite + " €");
            Console.WriteLine("Durée : " + Duree + " €");
            Console.WriteLine("Date début : " + DateDebut);
            Console.WriteLine("Capital Restant : ", capitalRestant(), " €");
        }
    }
}
