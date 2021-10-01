using System;
using System.Collections;
using System.Collections.Generic;

namespace SetsAndDictionariesAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var collection = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                collection.Add(input);
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
