using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Name = "SponsorStructure")]
    public class SponsorStructure
    {
        [DataMember(Name = "IdNo")]
        public double IdNo { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Status")]
        public string Status { get; set; }

        [DataMember(Name = "Occupation")]
        public string Occupation { get; set; }

        [DataMember(Name = "Type")]
        public LookupStructure Type { get; set; }
    }
}
