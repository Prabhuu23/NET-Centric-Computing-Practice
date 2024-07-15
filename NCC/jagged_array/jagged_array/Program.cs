using System;

namespace pratik_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize jagged array
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            // Display jagged array elements and their sums
            Console.WriteLine("Pratik");
            Console.WriteLine("1022");
            Console.WriteLine("*************");

            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int sum = 0;
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                    sum += jaggedArray[i][j];
                }
                Console.WriteLine(" - Sum: " + sum);
            }

            // Wait for user input at the end
            Console.ReadLine();
        }
    }
}
