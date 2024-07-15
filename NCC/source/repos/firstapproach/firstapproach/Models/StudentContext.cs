using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapproach.Models
{
    internal class StudentContext : DbContext
    {
        public DbSet<tbstudent> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;Database=StudentDB;Integrated Security=True;");
        }

    }
}