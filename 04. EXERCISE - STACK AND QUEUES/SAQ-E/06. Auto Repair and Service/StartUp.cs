
namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            var cars = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(cars);
            var history = new Stack<string>();
            var command = Console.ReadLine()
                .Split("-");
            while (command[0].ToLower() != "end")
            {
                switch (command[0])
                {
                    case "Service":
                        if (queue.Count > 0)
                        {
                            var car = queue.Dequeue();
                            history.Push(car);
                            Console.WriteLine($"Vehicle {car} got served.");
                        }
                        break;
                    case "CarInfo":
                        if (queue.Contains(command[1])) Console.WriteLine($"Still waiting for service.");
                        else Console.WriteLine($"Served.");
                        break;
                    case "History":
                        Console.WriteLine(string.Join(", ", history));
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split('-');
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", history)}");
        }
    }
}
