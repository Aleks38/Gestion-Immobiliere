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

        public int capitalRestant()
        {
            DateTime today = DateTime.Today;
            int diffMois = ((today.Year - this.DateDebut.Year) * 12) + today.Month - this.DateDebut.Month;
            int capitalRestant = 0;

            if (diffMois < this.Duree)
            {
                capitalRestant = (this.Duree - diffMois) * Mensualite;
            }

            return capitalRestant;
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
