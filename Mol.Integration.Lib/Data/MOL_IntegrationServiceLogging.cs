//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mol.Integration.Lib.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOL_IntegrationServiceLogging
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string MessageBody { get; set; }
        public string Contract { get; set; }
        public string Operation { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public bool Authorized { get; set; }
    }
}