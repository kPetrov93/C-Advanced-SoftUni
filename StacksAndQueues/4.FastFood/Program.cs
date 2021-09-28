using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int biggestOrder = int.MinValue;
            Queue<int> queue = new Queue<int>();

            foreach (var item in orders)
            {
                if (item>biggestOrder)
                {
                    biggestOrder = item;
                }
                queue.Enqueue(item);
            }

            while (queue.Count>0&&quantity>=0)
            {
                int currentEle = queue.Peek();

                if (quantity-currentEle>=0)
                {
                    quantity -= currentEle;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(biggestOrder);

            if (queue.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ",queue));
            }
        }
    }
}
