//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JneCommSitesDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Purchase
    {
        public int iPurchaseID { get; set; }
        public int iActivityLogID { get; set; }
        public short iPuchaseTypeID { get; set; }
        public Nullable<System.DateTime> dtPurchaseStartDate { get; set; }
        public Nullable<System.DateTime> dtPurchaseEndDate { get; set; }
        public string InvoiceName { get; set; }
        public string Description { get; set; }
    
        public virtual T_ActivityLog T_ActivityLog { get; set; }
        public virtual T_PurchaseType T_PurchaseType { get; set; }
    }
}
