using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            var sortedPeople = family.People.Where(x => x.Age > 30).OrderBy(x => x.Name);

            foreach (var item in sortedPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
