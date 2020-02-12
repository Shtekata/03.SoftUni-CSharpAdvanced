
namespace _06._Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class StartUp6
    {
        public static void Main()
        {
            var parking = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine())?.ToLower() != "end")
            {
                var carInfo = Regex.Split(input, ", ");
                if (carInfo[0]?.ToLower() == "in")
                {
                    parking.Add(carInfo[1]);
                }
                else
                {
                    parking.Remove(carInfo[1]);
                }
            }
            if (parking.Count != 0)
            {
                foreach (var item in parking)
                {
                    Console.WriteLine(item);
                }
            }
            else Console.WriteLine($"Parking Lot is Empty");
        }
    }
}
