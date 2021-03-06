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
    public class StatusStructure
    {
        [DataMember(Name = "PersonStatus")]
        public LookupStructure PersonStatus { get; set; }

        [DataMember(Name = "FingerPrintStatus")]
        public bool FingerPrintStatus { get; set; }

        [DataMember(Name = "PrisonerStatus")]
        public bool PrisonerStatus { get; set; }
    }
}
