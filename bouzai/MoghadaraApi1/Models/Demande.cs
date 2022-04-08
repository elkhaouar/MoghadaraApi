using System;
using System.Collections.Generic;

#nullable disable

namespace MoghadaraApi.Models
{
    public partial class Demande
    {
        public int IdDemd { get; set; }
        public string IdQuitterTerritoir { get; set; }
        public string NumDemande { get; set; }
        public string UserSaisie { get; set; }
        public string DateSaisie { get; set; }
        public string Valide { get; set; }
        public string Cause { get; set; }
        public string DateDebut { get; set; }
        public string Dure { get; set; }
        public string DateValideTab { get; set; }
        public string TelPay { get; set; }
        public string AdressPay { get; set; }
        public string InfoSuppTab { get; set; }
        public string DateAutorisation { get; set; }
        public double? FlagSupp { get; set; }
        public int? IdFonct { get; set; }
        public int? IdPay { get; set; }
        public double? IdEtab { get; set; }

        public virtual Etablissement IdEtabNavigation { get; set; }
        public virtual Fonctionnaire IdFonctNavigation { get; set; }
        public virtual Pay IdPayNavigation { get; set; }
    }
}
