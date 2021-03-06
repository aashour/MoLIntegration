﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Mol.Integration.Lib.Common;

namespace Mol.Integration.Lib.Contract.Data
{
    [DataContract(Namespace = Constants.Namespace)]
    public class ResidencyStructure
    {
        [DataMember(Name = "IdNo")]
        public double IdNo { get; set; }

        [DataMember(Name = "IdType")]
        public string IdType { get; set; }

        [DataMember(Name = "ExpiryDate")]
        public DateStructure ExpiryDate { get; set; }

        [DataMember(Name = "IssueDate")]
        public DateStructure IssueDate { get; set; }

        [DataMember(Name = "IssuePlace")]
        public string IssuePlace { get; set; }
    }
}
