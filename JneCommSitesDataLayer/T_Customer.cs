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
    
    public partial class T_Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Customer()
        {
            this.T_ContactsByCustomer = new HashSet<T_ContactsByCustomer>();
            this.T_Sites = new HashSet<T_Sites>();
        }
    
        public string vCustomerName { get; set; }
        public string vStateCode { get; set; }
        public string vCustomerAddress { get; set; }
        public string vCustomerCity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ContactsByCustomer> T_ContactsByCustomer { get; set; }
        public virtual T_USAStates T_USAStates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Sites> T_Sites { get; set; }
    }
}
