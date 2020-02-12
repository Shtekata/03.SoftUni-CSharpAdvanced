using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class RS
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var item in input)
            {
                stack.Push(item);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
