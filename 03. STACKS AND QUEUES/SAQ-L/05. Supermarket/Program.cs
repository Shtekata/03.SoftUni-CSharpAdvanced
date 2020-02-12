using System;
using System.Collections.Generic;

namespace _05._Supermarket
{
    class Program
    {
        static void Main()
        {
            var queue = new Queue<string>();
            var input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                if (input != "Paid")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    for (int i = queue.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(queue.Dequeue()); 
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
