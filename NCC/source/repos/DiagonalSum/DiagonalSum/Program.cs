using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the square matrix:");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.WriteLine("Enter the elements of the matrix:");

        // Input matrix elements
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Enter element at position [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Calculate sum of diagonal elements
        int diagonalSum = 0;
        for (int i = 0; i < n; i++)
        {
            diagonalSum += matrix[i, i];
        }

        // Display the sum
        Console.WriteLine($"Sum of diagonal elements: {diagonalSum}");
        Console.ReadLine(); // To keep the console window open
    }
}
