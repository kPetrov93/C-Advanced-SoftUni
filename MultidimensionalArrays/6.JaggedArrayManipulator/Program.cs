using System;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                
                    matrix[i] = input;
            }

            string[] splitted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int row = 0; row < matrix.Length-1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }

                    for (int col = 0; col < matrix[row+1].Length; col++)
                    {
                        matrix[row+1][col] /= 2;
                    }
                }


            }

            while (splitted[0]!="End")
            {
                string command = splitted[0];

                if (command=="Add")
                {
                    int row =int.Parse(splitted[1]);
                    int col = int.Parse(splitted[2]);
                    int value = int.Parse(splitted[3]);

                    if (row>=0 && row<matrix.Length && col>=0 && col<matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        splitted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }
                else if (command=="Subtract")
                {
                    int row = int.Parse(splitted[1]);
                    int col = int.Parse(splitted[2]);
                    int value = int.Parse(splitted[3]);

                    if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        splitted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        continue;
                    }
                }

                splitted = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
           
        }
    }
}
