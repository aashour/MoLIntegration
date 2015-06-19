using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Name = "TravelStructure")]
    public class TravelStructure
    {
        [DataMember(Name = "TravelStatus")]
        public string TravelStatus { get; set; }

        [DataMember(Name = "EntryDate")]
        public DateStructure EntryDate { get; set; }

        [DataMember(Name = "LastEntryDate")]
        public DateStructure LastEntryDate { get; set; }

        [DataMember(Name = "LastExitDate")]
        public DateStructure LastExitDate { get; set; }

        [DataMember(Name = "PassportExpiryDate")]
        public DateStructure PassportExpiryDate { get; set; }
    }
}
