using System;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = input => Console.WriteLine(string.Join(Environment.NewLine, input));

            string[] input = Console.ReadLine().Split();

            print(input);
        }
    }
}
