﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wrestling.dal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class student10Entities : DbContext
    {
        public student10Entities()
            : base("name=student10Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Away_Player> Away_Players { get; set; }
        public DbSet<Home_Player> Home_Players { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
