using System;
using System.Collections.Generic;

namespace EntityFramework.Models
{
    public class EmployeeDB
    {
        DbEntityFrameworkContext db = new DbEntityFrameworkContext();
        public void saveEmployee(string name, int age, string address, string email, float salary)
        {
            TbEntityFramework emp = new TbEntityFramework();
            
            emp.Name = name;    
            emp.Age = age;
            emp.Address = address;
            emp.Email = email;
            emp.Salary = salary;

            db.TbEntityFrameworks.Add(emp);
            db.SaveChanges();
        }

        public void showEmployeeInOrder()
        {
            foreach (TbEntityFramework employee in db.TbEntityFrameworks.ToList().OrderByDescending(employee => employee.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Age} {employee.Address} {employee.Email} {employee.Salary}");
            }
        }
        public void calcAggregateSalary(int count)
        {
            float aggregate = 0;
            foreach (TbEntityFramework employee in db.TbEntityFrameworks.ToList())
            {
                if(count > 0)
                {
                    aggregate = (float)(aggregate + employee.Salary);
                    count--;
                }
            }
            Console.WriteLine("The aggregate salary is {0}.", aggregate);
        }

        public void salaryGreaterThan5000AndAddressKathmandu()
        {
            var employees = db.TbEntityFrameworks.Where(e=> e.Salary > 50000 && e.Address == "Kathmandu").ToList();
            foreach(var employee in employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Age} {employee.Address} {employee.Email} {employee.Salary}");
            }
        }
    }
}
