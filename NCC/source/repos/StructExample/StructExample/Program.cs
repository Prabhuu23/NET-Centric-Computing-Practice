using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    struct SumOfStruct
    {
        public int x;
        public int y;

        public SumOfStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display()
        {
            int sum = x + y;
            Console.WriteLine("Sum of two numbers: " + sum);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SumOfStruct sumOfStruct = new SumOfStruct(2, 5);
            sumOfStruct.Display();
            Console.ReadLine();
        }
    }
}