using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            nums.Reverse();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % n == 0)
                {

                }
                else
                {
                    Console.Write(nums[i] + " ");
                }
            }
        }
    }
}
