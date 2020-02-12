using System;

namespace _01._Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "VW";
            myCar.Model = "MK3";
            myCar.Year = 1992;

            Console.WriteLine($"Make: {myCar.Make}\nModel: {myCar.Model}\nYear: {myCar.Year}");
        }
    }
}
