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
    
    public partial class MOL_IntegrationService
    {
        public MOL_IntegrationService()
        {
            this.MOL_IntegrationServiceConsumer = new HashSet<MOL_IntegrationServiceConsumer>();
        }
    
        public short Id { get; set; }
        public string ServiceName { get; set; }
        public string MethodName { get; set; }
    
        public virtual ICollection<MOL_IntegrationServiceConsumer> MOL_IntegrationServiceConsumer { get; set; }
    }
}
