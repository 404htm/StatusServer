//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StatusServer.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApiKey
    {
        public int Id { get; set; }
        public System.Guid Key { get; set; }
        public int ApplicationId { get; set; }
        public int EnvironmentId { get; set; }
        public int AuthInfoId { get; set; }
        public bool Active { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual AuthInfo AuthInfo { get; set; }
        public virtual Environment Environment { get; set; }
    }
}
