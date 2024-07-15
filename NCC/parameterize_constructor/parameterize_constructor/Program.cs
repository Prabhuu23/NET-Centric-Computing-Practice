using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterize_constructor
{
    public class Student
    {
        public int id;
        public string name;
        public int age;

        public Student(int i, string n, int a)
        {
            id = i;
            name = n;
            age = a;

        }
        public void display()
        {
            Console.WriteLine("ID:" + id + "\t" + "Name:" + name + "\t" + "Age:" + age);
        }


    }
    public class parameterize_constructor
    {

        static void Main(string[] args)
        {
            Student student = new Student(1, "ananta", 25);
            student.display();
            Console.ReadLine();

        }
    }

}