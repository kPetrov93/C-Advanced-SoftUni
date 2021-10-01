using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string, int>> dict = new Dictionary<string,Dictionary<string,int>>();
            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split(" -> ").ToArray();
                string color = splitted[0];
                if (splitted.Count() > 1)
                {
                    string[] leftOvers = splitted[1].Split(",").ToArray();

                    for (int j = 0; j < leftOvers.Count(); j++)
                    {
                        string currentWord = leftOvers[j];
                        if (!dict.ContainsKey(color))
                        {
                            dict.Add(color, new Dictionary<string, int>());
                        }

                        if (!dict[color].ContainsKey(currentWord))
                        {
                            dict[color].Add(currentWord, 1);
                        }
                        else
                        {
                            dict[color][currentWord]++;
                        }
                    }
                }
                else
                {
                    string leftOvers = splitted[1];

                    string currentWord = leftOvers;
                    if (!dict.ContainsKey(color))
                    {
                        dict.Add(color, new Dictionary<string, int>());
                    }

                    if (!dict[color].ContainsKey(currentWord))
                    {
                        dict[color].Add(currentWord, 1);
                    }
                    else
                    {
                        dict[color][currentWord]++;
                    }
                } 
            }
            string[] input = Console.ReadLine().Split().ToArray();
            string colour = input[0];
            string item = input[1];

            foreach (var items in dict)
            {
                Console.WriteLine($"{items.Key} clothes:");
                foreach (var things in items.Value)
                {
                    if (items.Key==colour && things.Key==item)
                    {
                        Console.WriteLine($"* {things.Key} - {things.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {things.Key} - {things.Value}");
                    }
                    
                }
            }
        }
    }
}
