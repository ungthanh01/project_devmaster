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
    
    public partial class tblBAOCAONHANVIEN
    {
        public long ID_BAOCAO { get; set; }
        public Nullable<long> ID_NHANVIEN { get; set; }
        public Nullable<System.DateTime> NGAY_BAOCAO { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<long> CREATE_BY { get; set; }
        public Nullable<long> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    
        public virtual tblNHANVIEN tblNHANVIEN { get; set; }
    }
}
