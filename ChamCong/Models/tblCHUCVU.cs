//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChamCong.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCHUCVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCHUCVU()
        {
            this.tblNHANVIENs = new HashSet<tblNHANVIEN>();
        }
    
        public long ID_CHUCVU { get; set; }
        public string TENCHUCVU { get; set; }
        public Nullable<long> CREATE_BY { get; set; }
        public Nullable<long> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNHANVIEN> tblNHANVIENs { get; set; }
    }
}
