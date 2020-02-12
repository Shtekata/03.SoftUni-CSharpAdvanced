
namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var greenLight = int.Parse(Console.ReadLine());
            var freeWindow = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var input = Console.ReadLine();
            var output = string.Empty;
            var passedCars = 0;
            var light = greenLight;
            while (input.ToLower() != "end")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    while (queue.Count > 0 && light > 0)
                    {
                        output = queue.Dequeue();
                        if (output.Length <= light)
                        {
                            light -= output.Length;
                            passedCars++;
                        }
                        else if (light + freeWindow >= output.Length)
                        {
                            passedCars++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"A crash happened!");
                            Console.WriteLine($"{output} was hit at {output[light + freeWindow]}.");
                            return;
                        }
                    }
                }
                light = greenLight;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
