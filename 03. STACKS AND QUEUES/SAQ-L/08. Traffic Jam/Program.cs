using System;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main()
        {
            var numberCars = int.Parse(Console.ReadLine());
            var car = Console.ReadLine();
            var queue = new Queue<string>();
            var numberLeftCars = 0;

            while (car.ToLower()!="end")
            {
                if (car.ToLower() != "green")
                {
                    queue.Enqueue(car);
                }
                else
                {
                    var leftCars = Math.Min(queue.Count, numberCars);
                    for (int i = 0; i < leftCars; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!"); 
                        numberLeftCars++;
                    }
                }
                car = Console.ReadLine();
            }
            Console.WriteLine($"{numberLeftCars} cars passed the crossroads.");
        }
    }
}
