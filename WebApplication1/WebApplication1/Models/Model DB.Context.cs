﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Model_x0020_DBContainer : DbContext
    {
        public Model_x0020_DBContainer()
            : base("name=Model_x0020_DBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<KKHObject> KKHObjectSet { get; set; }
        public DbSet<KKHBed> KKHBedSet { get; set; }
        public DbSet<KKHSystem> KKHSystemSet { get; set; }
        public DbSet<KKHPerson> KKHPersonSet { get; set; }
        public DbSet<Employee> EmployeeSet { get; set; }
    }
}
