using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Print_Even_Numbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(input);
            for (int i = 0; i < input.Length; i++)
            {
                var tempNumber = queue.Dequeue();
                if (tempNumber % 2 == 0)
                {
                    Console.Write($"{tempNumber}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
