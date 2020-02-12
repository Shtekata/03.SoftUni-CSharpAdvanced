using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            var parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < parameters[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < parameters[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(parameters[2]))
            {
                Console.WriteLine($"true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var minNumber = int.MaxValue;
                for (int i = queue.Count; i > 0; i--)
                {
                    var temp = queue.Dequeue();
                    if (temp < minNumber)
                    {
                        minNumber = temp;
                    }
                }
                Console.WriteLine(minNumber);
            }
        }
    }
}
