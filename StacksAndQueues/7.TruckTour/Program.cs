using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(input);

            }

            int index = 0;

            while (true)
            {
                int tank = 0;
                foreach (var item in queue)
                {
                    int gas = item[0];
                    int distance = item[1];

                    tank += gas;
                    tank -= distance;

                    if (tank < 0)
                    {
                        int[] currentElem = queue.Dequeue();
                        queue.Enqueue(currentElem);
                        index++;
                        break;
                    }
                }
                if (tank>=0)
                {
                    Console.WriteLine(index);
                    break;
                }
            }

        }
    }
}
