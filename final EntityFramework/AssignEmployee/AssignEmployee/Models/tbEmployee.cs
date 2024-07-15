using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignEmployee.Models
{
    internal class tbEmployee
    {
        [Key]
        public int Id { get; set; }

        public string? Emp_Name { get; set; }

        public double Salary { get; set; }

        public string? Emp_Address { get; set; }

    }
}