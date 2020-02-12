using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse);
            var capacity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            var counterOfRack = 0;
            var sum = 0;
            while (stack.Count > 0)
            {
                if (sum + stack.Peek() <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = 0;
                    counterOfRack++;
                }
            }
            counterOfRack++;
            Console.WriteLine(counterOfRack);
        }
    }
}
