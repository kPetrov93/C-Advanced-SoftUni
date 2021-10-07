using System;

namespace _2.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = input => Console.WriteLine("Sir "+string.Join(Environment.NewLine + "Sir ", input));

            string[] input = Console.ReadLine().Split();

            print(input);
        }
    }
}
