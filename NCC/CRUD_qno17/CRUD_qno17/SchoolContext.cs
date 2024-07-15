using Microsoft.EntityFrameworkCore;

namespace CRUD_qno17
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=your_server_name;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
