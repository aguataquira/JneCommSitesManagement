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
    
    public partial class T_UsersData
    {
        public int UsersDataId { get; set; }
        public string UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserDescription { get; set; }
        public Nullable<short> NumDaysForPassChange { get; set; }
        public Nullable<System.DateTime> PassRecoveryDate { get; set; }
        public string PassRecovery { get; set; }
        public Nullable<bool> ForcePassChange { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}