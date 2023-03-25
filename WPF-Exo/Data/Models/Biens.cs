using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;
using WPF_TP.Data.DAL;

namespace WPF_TP.Data.Models
{
    public class Biens
    {
        private string nom;
        private string adresse;
        private int valeur;
        private int surface;
        private List<Contrat>? listContrat = new List<Contrat>();
        private Pret? pret;
        private List<Intervention>? listIntervention;

        public int BiensId { get; set; }
        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Valeur { get => valeur; set => valeur = value; }
        public int Surface { get => surface; set => surface = value; }
        public List<Contrat>? ListContrat { get => listContrat; set => listContrat = value; }
        public Pret? Pret { get => pret; set => pret = value; }
        public List<Intervention>? ListIntervention { get => listIntervention; set => listIntervention = value; }

        public Biens(string nom, string adresse, int valeur, int surface)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.valeur = valeur;
            this.surface = surface;
        }

        public int benefNet()
        {
            int loyer = ListContrat[listContrat.Count - 1].Loyer;
            int mensualite = Pret.Mensualite;

            int benef = mensualite - loyer;
            return benef;
        }

        public virtual void afficher()
        {
            Console.WriteLine("Adresse : " + Adresse);
            Console.WriteLine("Valeur : " + Valeur);
            Console.WriteLine("Surface : " + Surface);
            Console.WriteLine("Benefice Net : " + benefNet());
        }
        public void jlespeindu()
        {
            Console.WriteLine("les abonnés ils m'ont di de la peindre, alors je l'ai peindu");
        }

        public int calculerRentabiliteNetMensuel()
        {
            int montantPret = 0;
            int loyer = 0;

            if (this.Pret != null)
            {
                montantPret = this.Pret.Mensualite;
            }

            if (this.listContrat.Count > 0)
            {
                foreach (Contrat contrat in this.listContrat)
                {
                    if (contrat.DateFin == null)
                    {
                        loyer = contrat.Loyer;
                        break;
                    }
                }
            }
            return loyer - montantPret;
        }
    }
}
