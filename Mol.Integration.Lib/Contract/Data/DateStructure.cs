using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Mol.Integration.Lib.Common;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Namespace = Constants.Namespace)]
    public class DateStructure
    {

        [DataMember]
        public System.DateTime GregorianDate
        {
            get;
            set;
        }

        [DataMember]
        public bool GregorianDateSpecified
        {
            get;
            set;
        }

        [DataMember]
        public string HijriDate
        {
            get;
            set;
        }
    }
}
