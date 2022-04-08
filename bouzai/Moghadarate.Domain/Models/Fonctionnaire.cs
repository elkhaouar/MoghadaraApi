using System;
using System.Collections.Generic;

#nullable disable

namespace Moghadarate.Domain.Models
{
    public partial class Fonctionnaire
    {
        public Fonctionnaire()
        {
            Demandes = new HashSet<Demande>();
        }

        public int IdFonct { get; set; }
        public double? Matricule { get; set; }
        public double? NumSomme { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Cin { get; set; }
        public bool? FlaFonctionnaire { get; set; }
        public double? IdEtab { get; set; }

        public virtual Etablissement IdEtabNavigation { get; set; }
        public virtual ICollection<Demande> Demandes { get; set; }
    }
}
