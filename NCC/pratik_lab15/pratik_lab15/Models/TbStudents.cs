using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik_lab15.Models
{
    internal class TbStudents
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Address { get; set; }

        public string? Gender { get; set; }
    }

}
