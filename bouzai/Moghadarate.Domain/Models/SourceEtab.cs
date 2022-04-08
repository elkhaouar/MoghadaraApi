using System;
using System.Collections.Generic;

#nullable disable

namespace Moghadarate.Domain.Models
{
    public partial class SourceEtab
    {
        public double? EtabId { get; set; }
        public string EtabLibelle { get; set; }
        public string EtabLibelleFr { get; set; }
        public double? EtabParentId { get; set; }
        public string EtabCodeRh { get; set; }
    }
}
