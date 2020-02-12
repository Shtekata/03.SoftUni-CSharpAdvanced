using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class SS
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(input);

            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split();
                var command = tokens[0];

                if (command == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (command == "remove" && stack.Count >= int.Parse(tokens[1]))
                {
                    for (int i = 0; i < int.Parse(tokens[1]); i++)
                    {
                        stack.Pop();
                    }
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            var sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
