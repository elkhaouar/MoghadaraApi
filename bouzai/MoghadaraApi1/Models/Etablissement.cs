using System;
using System.Collections.Generic;

#nullable disable

namespace MoghadaraApi.Models
{
    public partial class Etablissement
    {
        public Etablissement()
        {
            Demandes = new HashSet<Demande>();
            Fonctionnaires = new HashSet<Fonctionnaire>();
        }

        public double IdEtab { get; set; }
        public string LibelleEtab { get; set; }
        public string EtabCodeRh { get; set; }
        public string LibelleEtabFr { get; set; }
        public string EtabParentId { get; set; }

        public virtual ICollection<Demande> Demandes { get; set; }
        public virtual ICollection<Fonctionnaire> Fonctionnaires { get; set; }
    }
}
