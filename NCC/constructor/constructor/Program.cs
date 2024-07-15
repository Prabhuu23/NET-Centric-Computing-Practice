using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class NoArgumentConstructor
    {
        public NoArgumentConstructor()
        {
            Console.WriteLine("Constructor of class is called ");
        }
        public void display()
        {
            Console.WriteLine("NoArgumentConstructor");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            NoArgumentConstructor noArgumentConstructor = new NoArgumentConstructor();
            noArgumentConstructor.display();
        }
    }
}
