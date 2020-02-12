
namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                if (!wardrobe.ContainsKey(input[0]))
                {
                    wardrobe[input[0]] = new Dictionary<string, int>();
                }
                var input2 = input[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input2.Length; j++)
                {
                    if (!wardrobe[input[0]].ContainsKey(input2[j]))
                    {
                        wardrobe[input[0]][input2[j]] = 1;
                    }
                    else
                    {
                        wardrobe[input[0]][input2[j]]++;
                    }
                }
            }
            var lookingFor = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in wardrobe)
            {
                var found = false;
                if (item.Key == lookingFor[0])
                {
                    found = true;
                }
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    Console.Write($"* {item2.Key} - {item2.Value}");
                    if (item2.Key == lookingFor[1] && found)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
