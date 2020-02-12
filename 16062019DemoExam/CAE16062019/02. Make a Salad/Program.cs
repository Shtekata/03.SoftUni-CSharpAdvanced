using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Make_a_Salad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(input1);

            var input2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var stack = new Stack<int>(input2);

            var salads = new List<int>();
            var currentVegetable = string.Empty;
            var currentSalad = 0;
            var notFinish = true;

            while (notFinish)
            {
                if (stack.Count > 0)
                {
                    currentSalad = stack.Pop();
                }
                else
                {
                    notFinish = false;
                    break;
                }
                var makeSalad = currentSalad;
                while (makeSalad > 0)
                {
                    if (queue.Count > 0)
                    {
                        currentVegetable = queue.Dequeue();
                    }
                    else
                    {
                        notFinish = false;
                        break;
                    }
                    var currentVegNum = Convert(currentVegetable);

                    if (makeSalad <= currentVegNum)
                    {
                        salads.Add(currentSalad);
                        makeSalad = 0;
                        currentVegNum = 0;
                    }
                    else if (makeSalad > currentVegNum)
                    {
                        makeSalad -= currentVegNum;
                    }
                }

            }
            Console.WriteLine(string.Join(" ",salads));
            if (queue.Count > 0)
            {
                Console.WriteLine(string.Join(" ",queue));
            }
            else if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(" ",stack));
            }
        }

        private static int Convert(string vegetable)
        {
            var result = 0;
            switch (vegetable)
            {
                case "tomato":
                    result = 80;
                    break;
                case "carrot":
                    result = 136;
                    break;
                case "lettuce":
                    result = 109;
                    break;
                case "potato":
                    result = 215;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
