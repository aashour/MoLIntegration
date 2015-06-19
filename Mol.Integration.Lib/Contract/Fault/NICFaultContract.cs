using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Mol.Integration.Lib.Contract.Fault
{
    [DataContract(Name = "NICFaultContract")]
    public class NICFaultContract
    {
        public NICFaultContract()
        {
            Insert = new List<string>();
        }

        public string RaisedBy { get; set; }

        [DataMember]
        public string ErrorCode { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public List<string> Insert { get; set; }
    }
}
