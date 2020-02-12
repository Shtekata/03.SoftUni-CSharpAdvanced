
namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            var table = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (table.ContainsKey(input[i]))
                {
                    table[input[i]]++;
                }
                else
                {
                    table[input[i]] = 1;
                }
            }
            foreach (var item in table)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
