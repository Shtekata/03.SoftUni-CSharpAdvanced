
namespace _03._Product_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StrartUp3
    {
        public static void Main()
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (input[0]?.ToLower() != "revision")
            {
                if (!shops.ContainsKey(input[0]))
                {
                    shops[input[0]] = new Dictionary<string, double>();
                }
                shops[input[0]][input[1]] = double.Parse(input[2]);
                input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            foreach (var item in shops)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var shop in item.Value)
                {
                    Console.WriteLine($"Product: {shop.Key}, Price: {shop.Value}");
                }
            }
        }
    }
}
