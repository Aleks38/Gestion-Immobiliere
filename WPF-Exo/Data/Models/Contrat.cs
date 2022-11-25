using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    class Contrat
    {
        private int loyer;
        private string dateDebut;
        private string dateFin;
        private List<Locataire> listLocataire = new List<Locataire>();
        private Biens unBien;


        public Contrat(int loyer, string dateDebut, string dateFin, List<Locataire> listLocataire, Biens unBien)
        {
            Loyer = loyer;
            DateDebut = dateDebut;
            DateFin = dateFin;
            ListLocataire = listLocataire;
            UnBien = unBien;
        }
        public Contrat()
        {

        }
        public int ContratId { get; set; }
        public int Loyer { get => loyer; set => loyer = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        internal List<Locataire> ListLocataire { get => listLocataire; set => listLocataire = value; }
        public Biens UnBien { get => unBien; set => unBien = value; }
        public void afficher()
        {
            Console.WriteLine("===Bail===");
            Console.WriteLine("Loyer : " + Loyer + " €");
            Console.WriteLine("Date début : " + DateDebut);
            Console.WriteLine("Date fin : " + DateFin);
            foreach (Locataire locataire in ListLocataire)
            {
                Console.WriteLine("\n===Locataire===");
                Console.WriteLine("\n" + locataire.Nom + locataire.Prenom + " - " + locataire.Age + " - " + locataire.Profession);
            }
        }
    }
}