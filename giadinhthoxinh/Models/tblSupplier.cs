﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace giadinhthoxinh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblSupplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSupplier()
        {
            this.tblImportOrders = new HashSet<tblImportOrder>();
        }

        //public int PK_iSupplierID { get; set; }
        //public string sSupplierName { get; set; }
        //public string sPhone { get; set; }
        //public string sEmail { get; set; }
        //public string sAddress { get; set; }

        [Display(Name = "Mã nhà cung cấp")]
        public int PK_iSupplierID { get; set; }
        [Display(Name = "Tên nhà cung cấp")]
        [Required(ErrorMessage = "Vui lòng nhập tên nhà cung cấp")]
        public string sSupplierName { get; set; }
        [Display(Name = "SĐT")]
        [Required(ErrorMessage = "Vui lòng nhập SĐT nhà cung cấp")]
        public string sPhone { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Vui lòng nhập Email nhà cung cấp")]
        public string sEmail { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ nhà cung cấp")]
        public string sAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblImportOrder> tblImportOrders { get; set; }
    }
}
