﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntroductionOfSlv.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class intro : DbContext
    {
        public intro()
            : base("name=intro")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Introduction> Introductions { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Semister> Semisters { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<Year> Years { get; set; }
    }
}
