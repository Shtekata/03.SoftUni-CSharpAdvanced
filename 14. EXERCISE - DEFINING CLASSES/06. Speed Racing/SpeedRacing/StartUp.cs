using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StarUp
    {
       public static void Main(string[] args)
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                var model = data[0];
                var fuelAmount = double.Parse(data[1]);
                var fuelConsumptionPerKilometer = double.Parse(data[2]);
                var car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);

                cars.Add(car);
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var carModel = data[1];
                var distance = double.Parse(data[2]);

                var car = cars.FirstOrDefault(x => x.Model == carModel);
                car.Drive(distance);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
