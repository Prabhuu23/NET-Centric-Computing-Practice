using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualandoverrideExample
{
    public class BaseClass
    {
        public virtual int display(int a, int b)
        {
            return (a + b);
        }
    }

    public class DeriveClass : BaseClass
    {
        public override int display(int a, int b)
        {
            return (a + b) * 2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DeriveClass deriveClass = new DeriveClass();
            Console.WriteLine(deriveClass.display(2, 5));
            Console.ReadLine();
        }
    }
}
