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
    
    public partial class tblNHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNHANVIEN()
        {
            this.tblBANGCONGs = new HashSet<tblBANGCONG>();
            this.tblHOPDONGs = new HashSet<tblHOPDONG>();
            this.tblKHENTHUONGs = new HashSet<tblKHENTHUONG>();
            this.tblKILUATs = new HashSet<tblKILUAT>();
            this.tblNGHIPHEPs = new HashSet<tblNGHIPHEP>();
            this.tblNHANVIEN_PHUCAP = new HashSet<tblNHANVIEN_PHUCAP>();
            this.tblQUYENNVs = new HashSet<tblQUYENNV>();
            this.tblTANGCAs = new HashSet<tblTANGCA>();
            this.tblTKNVs = new HashSet<tblTKNV>();
            this.tblUNGLUONGs = new HashSet<tblUNGLUONG>();
            this.tblBAOHIEMs = new HashSet<tblBAOHIEM>();
            this.tblPHUCAPs = new HashSet<tblPHUCAP>();
            this.tblBAOCAONHANVIENs = new HashSet<tblBAOCAONHANVIEN>();
        }
    
        public long ID_NHANVIEN { get; set; }
        public string HOTEN { get; set; }
        public string CCCD { get; set; }
        public Nullable<bool> GIOITINH { get; set; }
        public string SDT { get; set; }
        public string QUEQUAN { get; set; }
        public string DIACHI { get; set; }
        public string DANTOC { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public Nullable<double> LUONG_CB { get; set; }
        public string EMAIL { get; set; }
        public Nullable<long> ID_TRINHDO { get; set; }
        public Nullable<long> ID_LUONG { get; set; }
        public Nullable<long> ID_PHONGBAN { get; set; }
        public Nullable<long> ID_CHUCVU { get; set; }
        public Nullable<long> CREATE_BY { get; set; }
        public Nullable<long> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBANGCONG> tblBANGCONGs { get; set; }
        public virtual tblCHUCVU tblCHUCVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHOPDONG> tblHOPDONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKHENTHUONG> tblKHENTHUONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKILUAT> tblKILUATs { get; set; }
        public virtual tblLUONG tblLUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNGHIPHEP> tblNGHIPHEPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNHANVIEN_PHUCAP> tblNHANVIEN_PHUCAP { get; set; }
        public virtual tblPHONGBAN tblPHONGBAN { get; set; }
        public virtual tblTRINHDO tblTRINHDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblQUYENNV> tblQUYENNVs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTANGCA> tblTANGCAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTKNV> tblTKNVs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUNGLUONG> tblUNGLUONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBAOHIEM> tblBAOHIEMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPHUCAP> tblPHUCAPs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBAOCAONHANVIEN> tblBAOCAONHANVIENs { get; set; }
    }
}