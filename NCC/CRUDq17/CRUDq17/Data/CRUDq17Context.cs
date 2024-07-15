using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDq17.Models;

namespace CRUDq17.Data
{
    public class CRUDq17Context : DbContext
    {
        public CRUDq17Context (DbContextOptions<CRUDq17Context> options)
            : base(options)
        {
        }

        public DbSet<CRUDq17.Models.Student> Student { get; set; } = default!;
    }
}
