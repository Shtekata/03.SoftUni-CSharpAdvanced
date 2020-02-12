using System;

namespace _02._Car_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "VW";
            myCar.Model = "MK3";
            myCar.Year = 1992;
            myCar.FuelQuantity = 200;
            myCar.FuelConsumption = 200;
            myCar.Drive(200);
            Console.WriteLine(myCar.WhoAmI());
        }
    }
}
