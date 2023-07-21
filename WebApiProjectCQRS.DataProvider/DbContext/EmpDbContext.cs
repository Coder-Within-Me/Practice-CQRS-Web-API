using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiProjectCQRS.Domain;

namespace WebApiProjectCQRS.DataProvider.DbContext
{
    public class EmpDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public EmpDbContext(DbContextOptions options) : base(options)
        {
           
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<EmployeeDetails>()
        //        .HasNoKey();
        //}
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<EmployeeDetails>? EmployeeDetails { get; set; }
    }
}
