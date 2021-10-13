using System;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "add")
                {
                    for (int i = 0; i < nums.Count(); i++)
                    {
                        nums[i]++;
                    }
                }
                else if (input == "multiply")
                {
                    for (int i = 0; i < nums.Count(); i++)
                    {
                        nums[i]*=2;
                    }
                }
                else if (input == "subtract")
                {
                    for (int i = 0; i < nums.Count(); i++)
                    {
                        nums[i]--;
                    }
                }
                else if (input== "print")
                {
                    Console.WriteLine(string.Join(" ",nums));
                }


                input = Console.ReadLine();
            }
        }
    }
}
