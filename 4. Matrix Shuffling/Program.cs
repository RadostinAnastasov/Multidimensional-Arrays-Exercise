using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = ReadMatrix(rows, cols);

            string[] comm = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (comm[0] != "END")
            {
                if (comm[0] == "swap")
                {
                    if (comm.Length == 5 &&
                        int.Parse(comm[1]) < rows &&
                        int.Parse(comm[2]) < cols &&
                        int.Parse(comm[3]) < rows &&
                        int.Parse(comm[4]) < cols)
                    {
                        string a;
                        string b;

                        a = matrix[int.Parse(comm[1]), int.Parse(comm[2])];
                        b = matrix[int.Parse(comm[3]), int.Parse(comm[4])];

                        matrix[int.Parse(comm[3]), int.Parse(comm[4])] = a;
                        matrix[int.Parse(comm[1]), int.Parse(comm[2])] = b;

                        PrintMatrix(rows, cols, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                comm = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            //PrintMatrix(rows, cols, matrix);

        }

        private static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row <= rows - 1; row++)
            {

                for (int col = 0; col <= cols - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();

            }
        }

        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
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
