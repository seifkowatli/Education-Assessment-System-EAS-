﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EAS_DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EAS_DatabaseEntities : DbContext
    {
        public EAS_DatabaseEntities()
            : base("name=EAS_DatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Course_Students> Course_Students { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ILO> ILOS { get; set; }
        public virtual DbSet<Question_Answers> Question_Answers { get; set; }
        public virtual DbSet<Questions_Bank> Questions_Bank { get; set; }
        public virtual DbSet<Semester_Courses> Semester_Courses { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student_Answers> Student_Answers { get; set; }
        public virtual DbSet<Students_Exams> Students_Exams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
    }
}
