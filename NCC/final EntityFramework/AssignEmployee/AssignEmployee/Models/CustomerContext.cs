using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignEmployee.Models
{
    internal class CustomerContext : DbContext
    {
        public DbSet<tbCustomer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;Database= EmployeeAssignDB;Integrated Security=True;");
        }
    }

}