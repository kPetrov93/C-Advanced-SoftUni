using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
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

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            int smallestElem = int.MaxValue;
            foreach (var item in queue)
            {
                if (item == X)
                {
                    Console.WriteLine("true");
                    return;
                }

                if (item < smallestElem)
                {
                    smallestElem = item;
                }
            }

            if (queue.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(smallestElem);
            }
        }
    }
}
