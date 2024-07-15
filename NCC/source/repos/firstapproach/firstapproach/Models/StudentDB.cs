using firstapproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapproach.Models
{
    internal class StudentDB
    {
        StudentContext db = new StudentContext();
        public void SaveStudent(string Name, string Address, double Salary, int age)
        {
            
            tbstudent st = new tbstudent();
            st.Name = Name;
            st.Address = Address;
            st.Salary = Salary;
            st.age = age;
            db.Students.Add(st);
            db.SaveChanges();
        }

    }
}