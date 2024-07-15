using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] first = new int[3, 3];
            Console.WriteLine("Please enter your matrix: \n");
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    first[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Your Enter first matrix are : \n");
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.Write("\t " + first[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
// matrix sum
//diagronal sum
//transpose matrix