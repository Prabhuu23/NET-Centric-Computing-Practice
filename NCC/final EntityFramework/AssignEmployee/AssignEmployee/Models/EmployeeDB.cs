using FirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignEmployee.Models
{
    internal class EmployeeAssignDB
    {
        EmployeeContext db = new EmployeeContext();

        public void SaveEmployee(string emp_name, double salary, string emp_address)
        {
            tbEmployee emp = new tbEmployee();
            emp.Emp_Name = emp_name;
            emp.Salary = salary;
            emp.Emp_Address = emp_address;

            db.Employees.Add(emp);
            db.SaveChanges();
        }
    }
}


/*public void HighSalary(int salary)
{
    var employees = db.Employees.Where(e => e.Salary > 50000 && e.Emp_Address == "Kathmandu").ToList();

    Console.WriteLine("Employees with Salary > 50000 and Address Kathmandu:");
    foreach (var employee in employees)
    {
        Console.WriteLine($"Name: {employee.Emp_Name}, Salary: {employee.Salary}, Address: {employee.Emp_Address}");
    }
} */
