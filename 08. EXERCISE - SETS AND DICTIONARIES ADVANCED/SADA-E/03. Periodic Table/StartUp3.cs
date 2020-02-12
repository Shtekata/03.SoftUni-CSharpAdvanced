
namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp3
    {
       public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var sortedSet = new SortedSet<string>();
            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < line.Length; j++)
                {
                    sortedSet.Add(line[j]);
                }
            }
            Console.WriteLine($"{string.Join(" ",sortedSet)}");
        }
    }
}
