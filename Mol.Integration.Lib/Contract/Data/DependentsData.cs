using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mol.Integration.Lib.Contract.Data;
using Mol.Integration.Lib.Common;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Namespace = Constants.Namespace)]
    public class DependentsData
    {
        [DataMember(Name = "Gender")]
        public string Gender { get; set; }

        [DataMember(Name = "Nationality")]
        public LookupStructure Nationality { get; set; }

        [DataMember(Name = "Occupation")]
        public LookupStructure Occupation { get; set; }

        [DataMember(Name = "Religion")]
        public LookupStructure Religion { get; set; }

        [DataMember(Name = "MaritalStatus")]
        public LookupStructure MaritalStatus { get; set; }

        [DataMember(Name = "Residency")]
        public ResidencyStructure Residency { get; set; }

        [DataMember(Name = "Status")]
        public StatusStructure Status { get; set; }

        [DataMember(Name = "Relationship")]
        public LookupStructure Relationship { get; set; }

        [DataMember(Name = "BirthDate")]
        public DateStructure BirthDate { get; set; }

        [DataMember(Name = "Visa")]
        public VisaStructure Visa { get; set; }

        [DataMember(Name = "Travel")]
        public TravelStructure Travel { get; set; }

        [DataMember(Name = "Name")]
        public NameStructure Name { get; set; }

        [DataMember(Name = "Sponsor")]
        public SponsorStructure Sponsor { get; set; }
    }


}
