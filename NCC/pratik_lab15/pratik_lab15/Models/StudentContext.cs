using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace pratik_lab15.Models
{
    internal class StudentContext : DbContext
    {
        public DbSet<TbStudents> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;Database= StudentLabDB;Integrated Security=True;");
        }
    }

}
