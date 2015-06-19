using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Name = "LookupStructure")]
    public class LookupStructure
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Code")]
        public int Code { get; set; }
    }
}
