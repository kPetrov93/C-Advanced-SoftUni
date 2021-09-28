using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input[0];
            int S = input[1];
            int X = input[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            int minItem = int.MaxValue;
            foreach (var item in stack)
            {
                if (item==X)
                {
                    Console.WriteLine("true");
                    return;
                }
                if (item<minItem)
                {
                    minItem = item;
                }
            }
            if (stack.Count>0)
            {
                Console.WriteLine(minItem);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
