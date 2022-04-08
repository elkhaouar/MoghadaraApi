using System;
using System.Collections.Generic;

#nullable disable

namespace MoghadaraApi.Models
{
    public partial class SourceExcel
    {
        public string IdQuitterTerritoire { get; set; }
        public string NumDemande { get; set; }
        public double? Matricule { get; set; }
        public double? NumSomme { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Cin { get; set; }
        public string Emails { get; set; }
        public string Tel { get; set; }
        public string Dure { get; set; }
        public string Cause { get; set; }
        public string Pays { get; set; }
        public string DateDebut { get; set; }
        public string TelPays { get; set; }
        public string AdressPays { get; set; }
        public string UserSaisie { get; set; }
        public string DateSaisie { get; set; }
        public string Valide { get; set; }
        public string CodeOrg { get; set; }
        public string LibelleEtablissement { get; set; }
        public string DateAutorisation { get; set; }
        public double? FlagSupp { get; set; }
        public string Datvalidetab { get; set; }
        public string Infosuppetab { get; set; }
    }
}
