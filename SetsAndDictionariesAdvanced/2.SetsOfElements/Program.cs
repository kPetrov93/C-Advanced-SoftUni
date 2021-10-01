using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double n = nums[0];
            double m = nums[1];
            var nSet = new HashSet<double>();
            var mSet = new HashSet<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                nSet.Add(input);
            }
            for (int j = 0; j < m; j++)
            {
                double input = double.Parse(Console.ReadLine());
                mSet.Add(input);
            }

            foreach (var items in nSet)
            {
                foreach (var item in mSet)
                {
                    if (items==item)
                    {
                        Console.Write(items + " ");
                    }
                }
            }
        }
    }
}
