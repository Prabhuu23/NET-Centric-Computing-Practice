using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databasedemo.Models
{
    internal class Employee
    {
        //DbEntityframeworkContext db = new DbEntityframeworkContext();
        DbDemoContext db = new DbDemoContext();
        public void SaveEmployee(string name, string address, int salary)
        {
            // TbEntityframework st=new TbEntityframework();
            TbDemo e = new TbDemo();

            e.Name = name;
            e.Address = address;
            e.Salary = salary;
            db.TbDemos.Add(e);
            db.SaveChanges();
        }
        public void showEmployeeInOrder()
        {
            foreach (TbDemo employee in db.TbDemos.ToList().OrderByDescending(employee => employee.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Address} {employee.Salary}");
            }
        }
        public void calcAggregateSalary(int count)
        {
            float aggregate = 0;
            foreach (TbDemo employee in db.TbDemos.ToList())
            {
                if (count > 0)
                {
                    aggregate = (float)(aggregate + employee.Salary);
                    count--;
                }
            }
            Console.WriteLine("The aggregate salary is {0}.", aggregate);
        }

        public void salaryGreaterThan50000AddressKathmandu()
        {
            var employees = db.TbDemos.Where(e => e.Salary > 50000 && e.Address == "Kathmandu").ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Address} {employee.Salary}");
            }
        }
    }
}