using System;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            string snake = Console.ReadLine();
            char[,] matrix = new char[rows, cols];

            bool isLeftToRight = true;
            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (isLeftToRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake[counter++];

                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                    isLeftToRight = false;
                }
                else
                {

                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[counter++];
                    
                        if (counter == snake.Length)
                        {
                            counter = 0;
                        }
                    }
                    
                    isLeftToRight = true;
                }
            }   
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }

        }
    }
}
