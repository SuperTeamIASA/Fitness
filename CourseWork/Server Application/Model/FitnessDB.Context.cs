﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server_Application.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FitnessCenterDBEntities : DbContext
    {
        public FitnessCenterDBEntities()
            : base("name=FitnessCenterDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aboniments> Aboniments { get; set; }
        public virtual DbSet<AbonimentsWithClient> AbonimentsWithClient { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfo { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<GroupLessons> GroupLessons { get; set; }
        public virtual DbSet<IndividualLesson> IndividualLesson { get; set; }
        public virtual DbSet<LessonsType> LessonsType { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<SportHalls> SportHalls { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TrainerInfo> TrainerInfo { get; set; }
    }
}
