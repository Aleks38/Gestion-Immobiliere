using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Prestataire
    {
        private string raisonSociale;
        private string nom;
        private string prenom;
        private string telephone;
        private string adresse;
        private List<Intervention>? listIntervention = new List<Intervention>();

        public Prestataire(string raisonSociale, string nom, string prenom, string telephone, string adresse, List<Intervention> listIntervention)
        {
            RaisonSociale = raisonSociale;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            Adresse = adresse;
            ListIntervention = listIntervention;

        }

        public Prestataire()
        {

        }

        public int PrestataireId { get; set; }
        public string RaisonSociale { get => raisonSociale; set => raisonSociale = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public List<Intervention> ListIntervention { get => listIntervention; set => listIntervention = value; }
    }
}
