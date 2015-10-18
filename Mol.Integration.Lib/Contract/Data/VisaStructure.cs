using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mol.Integration.Lib.Common;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Namespace = Constants.Namespace)]
    public class VisaStructure
    {
        [DataMember(Name = "VisaType")]
        public string VisaType { get; set; }

        [DataMember(Name = "VisaExpiryDate")]
        public DateStructure VisaExpiryDate { get; set; }

        [DataMember(Name = "FinalExitVisaIssued")]
        public bool FinalExitVisaIssued { get; set; }
    }
}
