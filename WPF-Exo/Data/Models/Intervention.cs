﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_TP.Data.Models
{
    public class Intervention
    {
        private string dateIntervention;
        private int montantTTC;
        private string information;
        private List<Prestataire> listPresta = new List<Prestataire>();
        private int bienId;

        public Intervention(string dateIntervention, int montantTTC, string information, List<Prestataire> listPresta, int bienId)
        {
            DateIntervention = dateIntervention;
            MontantTTC = montantTTC;
            Information = information;
            ListPresta = listPresta;
            BienId = bienId;
        }

        public Intervention()
        {

        }

        public int InterventionId { get; set; }
        public string DateIntervention { get => dateIntervention; set => dateIntervention = value; }
        public int MontantTTC { get => montantTTC; set => montantTTC = value; }
        public string Information { get => information; set => information = value; }
        public List<Prestataire> ListPresta { get => listPresta; set => listPresta = value; }
        public int BienId { get => bienId; set => bienId = value; }
    }
}
