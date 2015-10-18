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
    public class LookupStructure
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Code")]
        public int Code { get; set; }
    }
}
