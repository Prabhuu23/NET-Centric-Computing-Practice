using AssignEmployee.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApproach.Models
{
    internal class EmployeeContext : DbContext
    {
        public DbSet<tbEmployee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;Database= EmployeeAssignDB;Integrated Security=True;");
        }
    }
}