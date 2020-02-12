using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Simple_Calculator
{
    class Pr

    {
        static void Main()
        {
            var values = Console.ReadLine().Split().Reverse();
            var stack = new Stack<string>(values);
            while (stack.Count>1)
            {
                var first = int.Parse(stack.Pop());
                var sign = stack.Pop();
                var second = int.Parse(stack.Pop());
                
                switch (sign)
                {
                    
                    case "+": stack.Push((first + second).ToString());break;
                    case "-": stack.Push((first - second).ToString());break;
                    default:
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
