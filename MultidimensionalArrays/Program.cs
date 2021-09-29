using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputIntegers[col];
                }
            }

            int primaryCount = 0;
            int secondaryCount = 0;
            int counter = matrix.GetLength(1) - 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryCount += matrix[i, i];
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondaryCount += matrix[i, counter];
                counter--;
            }

            Console.WriteLine(Math.Abs(primaryCount-secondaryCount));
        }
    }
}
