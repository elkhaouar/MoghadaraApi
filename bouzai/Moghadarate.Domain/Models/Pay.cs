using System;
using System.Collections.Generic;

#nullable disable

namespace Moghadarate.Domain.Models
{
    public partial class Pay
    {
        public Pay()
        {
            Demandes = new HashSet<Demande>();
        }

        public int IdPay { get; set; }
        public string NomPay { get; set; }

        public virtual ICollection<Demande> Demandes { get; set; }
    }
}
