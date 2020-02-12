namespace _01._FirstTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var lineOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(lineOne);

            var lineTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var stack = new Stack<int>(lineTwo);

            var aluminium = 0;
            var carbonFiber = 0;
            var glass = 0;
            var lithium = 0;
            var crafts = false;
            var stop = false;

            while (!stop)
            {
                if (aluminium >= 1 && carbonFiber >= 1 && glass >= 1 && lithium >= 1)
                {
                    crafts = true;
                }
                if (queue.Count == 0 || stack.Count == 0)
                {
                    stop = true;
                    break;
                }
                var tempQueue = queue.Dequeue();
                var tempStack = stack.Pop();
                if (tempQueue + tempStack == 25)
                {
                    glass++;
                }
                else if (tempQueue + tempStack == 50)
                {
                    aluminium++;
                }
                else if (tempQueue + tempStack == 75)
                {
                    lithium++;
                }
                else if (tempQueue + tempStack == 100)
                {
                    carbonFiber++;
                }
                else
                {
                    tempStack += 3;
                    stack.Push(tempStack);
                }
            }
            if (crafts)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", queue)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (stack.Count > 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", stack)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }
            Console.WriteLine($"Aluminium: {aluminium}\nCarbon fiber: {carbonFiber}\nGlass: {glass}\nLithium: {lithium}");
        }
    }
}
