using System;
using System.Linq;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameAndAdress = Console.ReadLine().Split();
            string name = nameAndAdress[0];
            string familyName = nameAndAdress[1];
            string address = nameAndAdress[2];
            string city = string.Join(" ",nameAndAdress.Skip(3));

            string[] nameAndBeer = Console.ReadLine().Split();
            string nameBeer = nameAndBeer[0];
            int beerAmount = int.Parse(nameAndBeer[1]);
            string condition = nameAndBeer[2];
            bool isDrunk = false;
            if (condition=="drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }

            string[] intDouble = Console.ReadLine().Split();
            string integer = intDouble[0];
            double doubleNumber = double.Parse(intDouble[1]);
            string bank = intDouble[2];

            Threeuple<string, string,string> nameTown = new Threeuple<string, string,string>($"{name} {familyName}", address, city);
            Threeuple<string, int,bool> beer = new Threeuple<string, int,bool>(nameBeer, beerAmount,isDrunk);
            Threeuple<string, double,string> intAndDouble = new Threeuple<string, double,string>(integer, doubleNumber,bank);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(beer.GetItems());
            Console.WriteLine(intAndDouble.GetItems());
        }
    }
}
