using System;
using System.Linq;

namespace _2._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    
                    matrix[row, col] = input[col];
                }
            }
            int equals = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i , j + 1]&&matrix[i,j]==matrix[i+1,j+1]&&matrix[i,j]==matrix[i+1,j])
                    {
                        equals++;
                    }
                }
            }
            Console.WriteLine(equals);
        }
    }
}
