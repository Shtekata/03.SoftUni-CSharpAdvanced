
namespace ClubParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());

            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var stack = new Stack<string>();

            var queue = new Queue<string>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            var halls = new Dictionary<string, List<int>>();

            var curenntKey = string.Empty;

            while (stack.Count != 0)
            {
                var item = stack.Pop();

                if (char.IsNumber(item[0]) && halls.Count == 0)
                {
                    continue;
                }
                else if (!char.IsNumber(item[0]) && halls.Count == 0)
                {
                    curenntKey = item;
                    halls.Add(curenntKey, new List<int>());
                }
                else if (!char.IsNumber(item[0]))
                {
                    queue.Enqueue(item);
                }
                else if (char.IsNumber(item[0]))
                {
                    var number = int.Parse(item);

                    if (halls[curenntKey].Sum() + number > volume)
                    {
                        Console.WriteLine($"{curenntKey} -> {string.Join(", ", halls[curenntKey])}");

                        halls.Remove(curenntKey);

                        if (queue.Count > 0)
                        {
                            curenntKey = queue.Dequeue();

                            if (number <= volume)
                            {
                                halls.Add(curenntKey, new List<int>() { number });
                            }
                            else
                            {
                                halls.Add(curenntKey, new List<int>());
                            }
                        }
                    }
                    else if (halls.Count > 0)
                    {
                        halls[curenntKey].Add(number);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
