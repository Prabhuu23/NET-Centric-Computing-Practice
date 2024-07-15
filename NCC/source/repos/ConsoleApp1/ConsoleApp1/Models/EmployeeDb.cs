using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Models;

namespace ConsoleApp1.Models
{
    internal class EmployeeDb
    {
        private readonly MynewdatabaseContext db;

        public EmployeeDb()
        {
            db = new MynewdatabaseContext();
        }

        public void SaveEmployee(string name, int salary, string address)
        {
            TbEmployee employee = new TbEmployee
            {
                Name = name,
                Salary = salary,
                Address = address
            };

            db.TbEmployees.Add(employee);
            db.SaveChanges();
        }

        public List<TbEmployee> LoadEmployees()
        {
            return db.TbEmployees.ToList();
        }

        public void UpdateEmployee(int id, string name, int salary, string address)
        {
            TbEmployee employee = db.TbEmployees.Find(id);
            if (employee != null)
            {
                employee.Name = name;
                employee.Salary = salary;
                employee.Address = address;
                db.SaveChanges();
            }
        }

        public void DeleteEmployee(int id)
        {
            TbEmployee employee = db.TbEmployees.Find(id);
            if (employee != null)
            {
                db.TbEmployees.Remove(employee);
                db.SaveChanges();
            }
        }
    }
}
