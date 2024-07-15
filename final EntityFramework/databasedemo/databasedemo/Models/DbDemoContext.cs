using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace databasedemo.Models;

public partial class DbDemoContext : DbContext
{
    public DbDemoContext()
    {
    }

    public DbDemoContext(DbContextOptions<DbDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbDemo> TbDemos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=EmployeeAssignDB;Integrated Security =True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbDemo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_demo__3214EC07FCE7B210");

            entity.ToTable("tb_demo");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}