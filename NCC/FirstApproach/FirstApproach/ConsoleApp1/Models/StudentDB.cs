using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApproach.Models
{
    internal class StudentFirstDB
    {
        StudentContext db = new StudentContext();

        public void SaveStudent(string name, int salary, string address, int age)
        {
            tbStudent st = new tbStudent();
            //st.Id = id;
            st.Name = name;
            st.Salary = salary;
            st.Address = address;
            st.Age = age;

            db.Students.Add(st);
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var stu = db.Students.FirstOrDefault(a => a.Id == id);
            if (stu != null)
            {
                db.Students.Remove(stu);
                db.SaveChanges();
                Console.WriteLine("Student with ID {0} deleted successfully.", id);
            }
            else
            {
                Console.WriteLine("Student with ID {0} not found.", id);
            }
        }

        public void UpdateStudent(int id, string name, int salary, string address, int age)
        {
            var stu = db.Students.FirstOrDefault(a => a.Id == id);
            if (stu != null)
            {
                stu.Name = name;
                stu.Salary = salary;
                stu.Address = address;
                stu.Age = age;
                db.SaveChanges();
                Console.WriteLine("Student with ID {0} updated successfully.", id);
            }
            else
            {
                Console.WriteLine("Student with ID {0} not found.", id);
            }
        }


        /* public void DeleteStudent(int id) {
            var stu = db.Students.Where(a => a.Id == 2).FirstOrDefault();
            db.Students.Remove(stu);
            db.SaveChanges();
        }

        public void UpdateStudent(string name, int salary, string address, int age)
        {
            var stu = db.Students.Where(a => a.Id == 2).FirstOrDefault();
            stu.Name = name;
            stu.Salary = salary;
            stu.Address = address;
            stu.Age = age;
        } */
        public List<tbStudent> LoadStudent()
        {
            List<tbStudent> students = db.Students.ToList();
            return students;

        }
    }
}