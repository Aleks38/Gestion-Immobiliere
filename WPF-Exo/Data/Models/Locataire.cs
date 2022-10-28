using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    class Locataire
    {
        private string nom;
        private string prenom;
        private int age;
        private string profession;

        public Locataire(string nom, string prenom, int age, string profession)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Profession = profession;
        }
        public int LocataireId { get; set; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }

    }
}
