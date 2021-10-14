using System;
using System.Linq;

namespace _8.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 1; i <= n; i++)
            {
                bool isDevisible = true;
                for (int j = 0; j < numbers.Count(); j++)
                {
                    if (i % numbers[j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        isDevisible = false;
                    }
                }
                if (isDevisible)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
