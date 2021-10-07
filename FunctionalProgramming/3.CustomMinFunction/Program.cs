using System;
using System.Linq;

namespace _3.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> min = numbers =>
            {
                int minValue = int.MaxValue;

                foreach (var item in numbers)
                {
                    if (item < minValue)
                    {
                        minValue = item;
                    }
                }

                return minValue;
            };

            Console.WriteLine(min(Console.ReadLine().Split().Select(int.Parse).ToArray()));
        }
    }
}
