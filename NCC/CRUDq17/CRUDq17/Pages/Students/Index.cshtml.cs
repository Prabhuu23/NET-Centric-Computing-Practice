using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDq17.Data;
using CRUDq17.Models;

namespace CRUDq17.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly CRUDq17.Data.CRUDq17Context _context;

        public IndexModel(CRUDq17.Data.CRUDq17Context context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
