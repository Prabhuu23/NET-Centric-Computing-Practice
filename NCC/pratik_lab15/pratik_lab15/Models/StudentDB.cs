using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik_lab15.Models
{
    internal class StudentLabDB
    {
        StudentContext db = new StudentContext();

        public void SaveStudent(string name, int age, string address, string gender)
        {
            TbStudents st = new TbStudents();
            st.Name = name;
            st.Age = age;
            st.Address = address;
            st.Gender = gender;

            db.Students.Add(st);
            db.SaveChanges();
        }

        public List<TbStudents> LoadStudent()
        {
            List<TbStudents> students = db.Students.ToList();
            return students;

        }

    }

}
