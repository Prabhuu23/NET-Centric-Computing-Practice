using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EmployeeDbContext())
            {
                // Insert record
                var newEmployee = new Employee
                {
                    Name = "John Doe",
                    Address = "123 Main St",
                    Salary = 50000,
                    Gender = "Male"
                };

                context.Employees.Add(newEmployee);
                
                context.SaveChanges();


                Console.WriteLine("Record inserted successfully.");

                // Display records
                var employees = context.Employees;
                Console.WriteLine("List of Employees:");
                foreach (var emp in employees)
                {
                    Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}, Salary: {emp.Salary}, Gender: {emp.Gender}");
                }
            }
        }
    }
}
