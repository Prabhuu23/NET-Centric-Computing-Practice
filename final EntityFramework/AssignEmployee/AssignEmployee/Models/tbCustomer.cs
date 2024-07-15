using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignEmployee.Models
{
    internal class tbCustomer
    {
        [Key]
        public int Id { get; set; }

        public string? AccountNo { get; set; }

        public string? Cus_Name { get; set; }

        public string? Cus_Address { get; set; }

        public double Balance { get; set; }
    }

}