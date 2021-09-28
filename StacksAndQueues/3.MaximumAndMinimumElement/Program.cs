using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int action = input[0];

                if (action == 1)
                {
                    int num = input[1];
                    stack.Push(num);
                }
                else if (action == 2)
                {
                    stack.Pop();
                }
                else if (action == 3)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    foreach (var item in stack)
                    {
                        if (item > maxNum)
                        {
                            maxNum = item;
                        }
                    }
                    Console.WriteLine(maxNum);
                }
                else if (action == 4)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    foreach (var item in stack)
                    {
                        if (item < minNum)
                        {
                            minNum = item;
                        }
                    }
                    Console.WriteLine(minNum);
                }
            }
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
