using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            var parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < parameters[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < parameters[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(parameters[2]))
            {
                Console.WriteLine($"true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var minNumber = int.MaxValue;
                while (stack.Count>0)
                {
                    var temp = stack.Pop();
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
