using System;

namespace CarManufacturer
{
    public class StartUp
    {
        class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;

            public string Make { get { return make; } set { make = value; } }

            public string Model { get { return model; } set { model = value; } }

            public int Year { get { return year; } set { year = value; } }

            public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

            public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }

            public void Drive(double distance)
            {
                var consumption = distance * FuelConsumption / 100.0;

                if (consumption <= FuelQuantity)
                {
                    FuelQuantity -= consumption;
                }
                else
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                }
            }

            public string WhoAmI()
            {
                return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity}";
            }
        }

        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2025;
            car.FuelQuantity = 200;
            car.FuelConsumption = 10;
            car.Drive(2000);
        }
            
        
    }
}
