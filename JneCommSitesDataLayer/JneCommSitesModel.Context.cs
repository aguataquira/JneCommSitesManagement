﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JneCommSitesDataBaseEntities : DbContext
    {
        public JneCommSitesDataBaseEntities()
            : base("name=JneCommSitesDataBaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<T_Operations> T_Operations { get; set; }
        public virtual DbSet<T_CrewRoles> T_CrewRoles { get; set; }
        public virtual DbSet<T_PaymentPeriod> T_PaymentPeriod { get; set; }
        public virtual DbSet<T_TechEvolutionCodes> T_TechEvolutionCodes { get; set; }
        public virtual DbSet<T_ContactsByCustomer> T_ContactsByCustomer { get; set; }
        public virtual DbSet<T_Customer> T_Customer { get; set; }
        public virtual DbSet<T_USAStates> T_USAStates { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<T_Certifications> T_Certifications { get; set; }
        public virtual DbSet<T_CertificationsByUserCrew> T_CertificationsByUserCrew { get; set; }
        public virtual DbSet<T_UsersData> T_UsersData { get; set; }
        public virtual DbSet<vwUserData> vwUserData { get; set; }
        public virtual DbSet<T_Sites> T_Sites { get; set; }
    }
}
