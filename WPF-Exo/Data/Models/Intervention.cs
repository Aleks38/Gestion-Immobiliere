using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    class Intervention
    {
        private string dateIntervention;
        private int montantTTC;
        private string information;
        private List<Prestataire> listPresta = new List<Prestataire>();
        private Biens unBien;

        public Intervention(string dateIntervention, int montantTTC, string information, List<Prestataire> listPresta, Biens unBien)
        {
            DateIntervention = dateIntervention;
            MontantTTC = montantTTC;
            Information = information;
            ListPresta = listPresta;
            UnBien = unBien; 
            
        }
        public Intervention()
        {

        }
        public int InterventionId { get; set; }
        public string DateIntervention { get => dateIntervention; set => dateIntervention = value; }
        public int MontantTTC { get => montantTTC; set => montantTTC = value; }
        public string Information { get => information; set => information = value; }
        internal List<Prestataire> ListPresta { get => listPresta; set => listPresta = value; }
        public Biens UnBien { get => unBien; set => unBien = value; }
    }
}
