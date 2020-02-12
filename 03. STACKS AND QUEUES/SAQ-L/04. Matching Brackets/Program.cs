using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                if (input[i] == ')')
                {
                    var startIndex = stack.Pop();
                    var output = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(output);
                }
            }
        }
    }
}
