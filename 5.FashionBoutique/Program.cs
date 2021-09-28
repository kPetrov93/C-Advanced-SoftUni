using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cloths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            Stack<int> stack = new Stack<int>();

            foreach (var item in cloths)
            {
                stack.Push(item);
            }

            int currentSum = 0;

            foreach (var item in stack)
            {
                if (currentSum + item <= capacity)
                {
                    currentSum += item;
                    
                }
                else
                {
                    currentSum = item;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
