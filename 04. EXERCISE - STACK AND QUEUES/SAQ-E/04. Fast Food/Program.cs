using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main()
        {
            var quantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var queue = new Queue<int>();
            var maxOrder = int.MinValue;
            foreach (var item in orders)
            {
                if (item > maxOrder) maxOrder = item;
                queue.Enqueue(item);
            }
            while (queue.Count > 0 && quantity >= queue.Peek())
            {
                quantity -= queue.Dequeue();
            }
            Console.WriteLine(maxOrder);
            if (queue.Count > 0)
            {
                var list = new List<int>();
                foreach (var item in queue)
                {
                    list.Add(item);
                }
                Console.WriteLine($"Orders left: {string.Join(" ", list)}");
            }
            else Console.WriteLine($"Orders complete");
        }
    }
}
