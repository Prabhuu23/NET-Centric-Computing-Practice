using System;

class MatrixSumProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows for the matrices:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns for the matrices:");
        int columns = int.Parse(Console.ReadLine());

        // Creating the first matrix
        int[,] matrix1 = CreateMatrix(rows, columns);

        // Creating the second matrix
        int[,] matrix2 = CreateMatrix(rows, columns);

        // Printing the first matrix
        Console.WriteLine("\nMatrix 1:");
        PrintMatrix(matrix1);

        // Printing the second matrix
        Console.WriteLine("\nMatrix 2:");
        PrintMatrix(matrix2);

        // Summing the matrices
        int[,] sumMatrix = SumMatrices(matrix1, matrix2);

        // Printing the sum matrix
        Console.WriteLine("\nSum of the matrices:");
        PrintMatrix(sumMatrix);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static int[,] CreateMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];

        Console.WriteLine($"\nEnter the elements for a {rows}x{columns} matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element at position ({i + 1},{j + 1}): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] SumMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] sumMatrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return sumMatrix;
    }
}
