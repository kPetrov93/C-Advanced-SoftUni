using System;
using System.Collections.Generic;
using System.Text;

namespace _9.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            Stack<string> saved = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                if (command == 1)
                {
                    saved.Push(sb.ToString());
                    string text = input[1];
                    sb.Append(text);
                }
                else if (command == 2)
                {
                    saved.Push(sb.ToString());
                    int num = int.Parse(input[1]);
                    
                    while (num>0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        num--;
                    }
                }
                else if (command == 3)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(sb[index-1]);
                }
                else if (command==4)
                {
                    sb.Clear();
                    sb.Append(saved.Pop());
                }

            }
        }
    }
}
