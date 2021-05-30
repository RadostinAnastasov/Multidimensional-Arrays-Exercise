using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Варянт 2
            int[,] matrix = ReadMatrix(n, n);

            //Варянт 1:
            //int[,] matrix = new int[n, n];
           
            //for (int row = 0; row < n; row++)
            //{
            //    int[] rowValues = Console.ReadLine()
            //        .Split(" ")
            //        .Select(int.Parse)
            //        .ToArray();

            //    for (int col = 0; col < n; col++)
            //    {
            //        matrix[row, col] = rowValues[col];
            //    }
            //}

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                primaryDiagonal += matrix[row, row];
                secondaryDiagonal += matrix[row, n - row - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
        //Варянт 2++
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
    }
}
