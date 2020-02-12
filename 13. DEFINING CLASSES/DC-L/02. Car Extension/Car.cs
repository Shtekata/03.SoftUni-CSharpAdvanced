using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Car_Extension
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distanse)
        {
            if (FuelQuantity - FuelConsumption * distanse / 100 >= 0)
            {
                FuelQuantity -= FuelConsumption * distanse / 100;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perfom this trip!");
            }
        }
        public string WhoAmI()
        {
            var output = new StringBuilder();
            output.AppendLine($"Make: {Make}");
            output.AppendLine($"Model: {Model}");
            output.AppendLine($"Year: {Year}");
            output.Append($"Fuel: {FuelQuantity:f2}L");
            return output.ToString();
        }
    }
}
