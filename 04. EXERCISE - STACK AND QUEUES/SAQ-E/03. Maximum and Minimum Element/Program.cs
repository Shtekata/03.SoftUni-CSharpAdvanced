using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main()
        {
            var queries = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var minNumber = int.MaxValue;
            var maxNumber = int.MinValue;
            for (int i = 0; i < queries; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                switch (input[0])
                {
                    case 1:
                        stack.Push(input[1]);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            foreach (var item in stack)
                            {
                                if (item > maxNumber) maxNumber = item;
                            }
                            Console.WriteLine(maxNumber);
                        }
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            foreach (var item in stack)
                            {
                                if (item < minNumber) minNumber = item;
                            }
                            Console.WriteLine(minNumber);
                        }
                        break;
                    default:
                        break;
                }
            }
            var array = new List<int>();
            while (stack.Count > 0)
            {
                array.Add(stack.Pop());
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
