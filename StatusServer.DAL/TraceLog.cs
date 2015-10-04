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
    
    public partial class TraceLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraceLog()
        {
            this.AncillaryDatas = new HashSet<AncillaryData>();
            this.ObjectDatas = new HashSet<ObjectData>();
        }
    
        public int Id { get; set; }
        public System.Guid Token { get; set; }
        public System.DateTime Time { get; set; }
        public string UserName { get; set; }
        public int EnvironmentId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public string Version { get; set; }
        public Nullable<int> LineNumber { get; set; }
        public string MemberName { get; set; }
        public string FileName { get; set; }
        public string Message { get; set; }
    
        public virtual ApplicationVersion ApplicationVersion { get; set; }
        public virtual Environment Environment { get; set; }
        public virtual Module Module { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AncillaryData> AncillaryDatas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectData> ObjectDatas { get; set; }
    }
}
