using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            foreach (var item in names)
            {
                if (item.Length<=n)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
