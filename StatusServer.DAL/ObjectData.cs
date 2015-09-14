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
    
    public partial class ObjectData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObjectData()
        {
            this.AssertLogs = new HashSet<AssertLog>();
            this.ErrorLogs = new HashSet<ErrorLog>();
            this.TraceLogs = new HashSet<TraceLog>();
        }
    
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string InstanceName { get; set; }
        public string Data { get; set; }
        public string Format { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssertLog> AssertLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraceLog> TraceLogs { get; set; }
    }
}
