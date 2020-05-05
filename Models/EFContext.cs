using EmoplyeesApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Models
{
    class EFContext : DbContext
    {
        private const string connctionString = "server=localhost\\SQLEXPRESS;Database=EmployeeDb;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connctionString);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Incentive> Incentives { get; set; }
        
    }
}
