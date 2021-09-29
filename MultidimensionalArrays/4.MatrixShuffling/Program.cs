using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string commandArgs = Console.ReadLine();

            while (commandArgs!="END")
            {
                string[] splitted = commandArgs.Split();
                string command = splitted[0];

                if (command == "swap")
                {
                    if (splitted.Length == 5)
                    {
                        int row1 = int.Parse(splitted[1]);
                        int col1 = int.Parse(splitted[2]);
                        int row2 = int.Parse(splitted[3]);
                        int col2 = int.Parse(splitted[4]);

                        if (row1 >= matrix.GetLength(0) || col1 >= matrix.GetLength(1) || row2 >= matrix.GetLength(0) || col2 >= matrix.GetLength(1))
                        {
                            Console.WriteLine("Invalid input!");
                            commandArgs = Console.ReadLine();
                            continue;
                        }

                        string currentDig = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = currentDig;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        commandArgs = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    commandArgs = Console.ReadLine();
                    continue;
                }

                commandArgs = Console.ReadLine();
            }
        }
    }
}
