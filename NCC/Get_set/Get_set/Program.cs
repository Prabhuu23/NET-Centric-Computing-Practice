using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set              //ReadWriteonlyproperties
{
    public class Student
    {
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
           set
            {
                name = value;
            } 
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            //writting into property
            st.Name = "Pratik khadka";

            Console.WriteLine(st.Name);

            Console.ReadLine();
        }
    }
}
