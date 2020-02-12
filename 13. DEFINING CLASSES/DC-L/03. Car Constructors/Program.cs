using System;

namespace _03._Car_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var make = Console.ReadLine();
            var model = Console.ReadLine();
            var year = int.Parse(Console.ReadLine());
            var fuelQuantity = double.Parse(Console.ReadLine());
            var fuelConsumption = double.Parse(Console.ReadLine());

            var firstCar = new Car();
            var secondCar = new Car(make, model, year);
            var thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            Console.WriteLine($"Make: {firstCar.Make}\nModel: {firstCar.Model}\nYear: {firstCar.Year}\nFuelQuantity: {firstCar.FuelQuantity}\nFuelConsumption: {firstCar.FuelConsumption}");
            Console.WriteLine($"Make: {secondCar.Make}\nModel: {secondCar.Model}\nYear: {secondCar.Year}\nFuelQuantity: {secondCar.FuelQuantity}\nFuelConsumption: {secondCar.FuelConsumption}");
            Console.WriteLine($"Make: {thirdCar.Make}\nModel: {thirdCar.Model}\nYear: {thirdCar.Year}\nFuelQuantity: {thirdCar.FuelQuantity}\nFuelConsumption: {thirdCar.FuelConsumption}");
        }
    }
}
