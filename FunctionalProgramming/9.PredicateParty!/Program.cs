using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            string[] input = Console.ReadLine().Split();

            while (input[0]!="Party!")
            {
                string command = input[0];
                string secondCommand = input[1];

                if (secondCommand == "Lenght")
                {
                    int lenght = int.Parse(input[2]);

                    if (command == "Double")
                    {
                        foreach (var item in people)
                        {
                            if (item.Length == lenght)
                            {
                                int index = people.IndexOf(item);
                                people.Insert(index, item);
                            }
                        }
                    }
                    else if (command == "Remove")
                    {
                        foreach (var item in people)
                        {
                            if (item.Length == lenght)
                            {
                                people.Remove(item);
                            }
                        }
                    }
                }

                else if (secondCommand == "StartsWith")
                {
                    string letter = input[2];

                    if (command == "Double")
                    {
                        foreach (var item in people)
                        {
                            if (item.StartsWith(letter))
                            {
                                int index = people.IndexOf(item);
                                people.Insert(index, item);
                            }
                        }
                    }
                    else if (command == "Remove")
                    {
                        for (int i = 0; i < people.Count(); i++)
                        {
                            if (people[i].StartsWith(letter))
                            {
                                people.Remove(people[i]);
                            }
                        }
                        
                    }
                }

                else if (secondCommand == "EndsWith")
                {
                    string letter = input[2];

                    if (command == "Double")
                    {
                        foreach (var item in people)
                        {
                            if (item.EndsWith(letter))
                            {
                                int index = people.IndexOf(item);
                                people.Insert(index, item);
                            }
                        }
                    }
                    else if (command == "Remove")
                    {
                        foreach (var item in people)
                        {
                            if (item.EndsWith(letter))
                            {
                                people.Remove(item);
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split();
            }
            if (people.Count() == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(", ",people) + " are going to the party!");
            }
        }
    }
}
