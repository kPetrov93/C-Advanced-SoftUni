using System;
using System.Collections.Generic;

namespace _6.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>();

            foreach (var item in input)
            {
                queue.Enqueue(item);
            }

            while (queue.Count > 0)
            {
                string[] input2 = Console.ReadLine().Split();
                string action = input2[0];

                if (action == "Play")
                {
                    queue.Dequeue();
                }
                else if (action == "Add")
                {
                    string[] word = string.Join(" ", input2).Split("Add ");
                    string song = word[1];

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
