using System;
using System.Linq;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                string typeOfVehicle = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                int horsePower = int.Parse(tokens[3]);

                if (typeOfVehicle == "car")
                {
                    Car car = new Car()
                    {
                        Type = "Car",
                        Model = model,
                        Color = color,
                        HorsePower = horsePower,
                    };
                    cars.Add(car);
                }

                else if (typeOfVehicle == "truck")
                {
                    Truck truck = new Truck()
                    {
                        Type = "Truck",
                        Model = model,
                        Color = color,
                        HorsePower = horsePower,
                    };
                    trucks.Add(truck);
                }
            }

            string wishVehicle = string.Empty;

            while ((wishVehicle = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {
                    if (wishVehicle == car.Model)
                    {
                        Console.WriteLine($"Type: {car.Type}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

                foreach (Truck truck in trucks)
                {
                    if (wishVehicle == truck.Model)
                    {
                        Console.WriteLine($"Type: {truck.Type}");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }
            }
            double carAllHp = 0.00;
            double carAverageHp = 0.00;
            double truckAllHp = 0.00;
            double truckAverageHp = 0.00;
            foreach (Car car in cars)
            {
                carAllHp += car.HorsePower;
                carAverageHp = carAllHp / cars.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: {carAverageHp:F2}.");
            foreach (Truck truck in trucks)
            {
                truckAllHp += truck.HorsePower;
                truckAverageHp = truckAllHp / trucks.Count;
            }
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHp:F2}.");
        }
        class Truck
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }
        }
        class Car
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }
        }
    }
}
