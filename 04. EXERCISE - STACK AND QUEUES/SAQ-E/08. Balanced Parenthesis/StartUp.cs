
namespace _08._Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            var balanced = true;
            var open = new char[] { '(', '[', '{' };

            foreach (var item in input)
            {
                if (open.Contains(item))
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count == 0)
                {
                    balanced = false;
                    break;
                }
                if (stack.Peek() == '(' && item == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && item == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && item == '}')
                {
                    stack.Pop();
                }
                else
                {
                    balanced = false;
                    break;
                }
            }
            if (balanced) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}