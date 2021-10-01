using System;
using System.Collections.Generic;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!set.Contains(input[j]))
                    {
                        set.Add(input[j]);
                    }
                }
            }

            foreach (var item in set)
            {
                Console.Write(item + " ");
            }
        }
    }
}
