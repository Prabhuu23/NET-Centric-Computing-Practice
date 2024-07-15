using Microsoft.EntityFrameworkCore;

public class EmployeeDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;Database=EmployeeManDB;Integrated Security=True;");
    }
}
