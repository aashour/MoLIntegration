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
    public class NameStructure
    {
        [DataMember(Name = "FullName")]
        public string FullName { get; set; }

        [DataMember(Name = "FirstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "LastName")]
        public string LastName { get; set; }

        [DataMember(Name = "SecondName")]
        public string SecondName { get; set; }

        [DataMember(Name = "ThirdName")]
        public string ThirdName { get; set; }

        [DataMember(Name = "TranslatedName")]
        public NameStructure TranslatedName { get; set; }
    }
}
