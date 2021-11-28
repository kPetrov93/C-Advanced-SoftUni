using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T current = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = current;
        }

        public int CountGreaterThan(T item)
        {
            int count = 0;

            foreach (var currentItem in items)
            {
                if (currentItem.CompareTo(item) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in items)
            {
                string value = item.GetType().ToString();
                stringBuilder.AppendLine($"{value}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        } 
    }
}
