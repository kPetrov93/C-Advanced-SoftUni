using System;
using System.Collections.Generic;

namespace _8.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> parentheses = new Stack<char>();
            bool isBalanced = true;

            foreach (var symbol in input)
            {
                if (symbol == '{' || symbol == '[' || symbol == '(')
                {
                    parentheses.Push(symbol);
                }
                else
                {
                    if (parentheses.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    bool isValid = (symbol == '}' && parentheses.Peek() == '{') ||
                        (symbol == ']' && parentheses.Peek() == '[') ||  (symbol == ')' && parentheses.Peek() == '(');

                    if (isValid)
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
