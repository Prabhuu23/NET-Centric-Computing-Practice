using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaseKeywordExample
{
    public class BaseKeywordClass
    {
        public BaseKeywordClass(int age)
        {
            Console.WriteLine("Age: " + age);
        }

        public string name = "Pratik Khadka";
        public string location = "Kathmandu";

        public virtual void displayDetails()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
            Console.WriteLine("BaseClass");
        }
    }

    public class DerivedKeywordClass : BaseKeywordClass
    {
        public DerivedKeywordClass(int age) : base(age)
        {
           
        }

        public override void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("DerivedClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DerivedKeywordClass derivedKeywordClass = new DerivedKeywordClass(20);
            derivedKeywordClass.displayDetails();
            Console.ReadLine();
        }
    }
}
