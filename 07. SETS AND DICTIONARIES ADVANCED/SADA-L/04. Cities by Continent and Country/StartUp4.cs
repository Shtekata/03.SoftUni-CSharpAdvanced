
namespace _04._Cities_by_Continent_and_Country
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!continents.ContainsKey(input[0]))
                {
                    continents[input[0]] = new Dictionary<string, List<string>>();
                }
                if (!continents[input[0]].ContainsKey(input[1]))
                {
                    continents[input[0]][input[1]] = new List<string>();
                }
                continents[input[0]][input[1]].Add(input[2]);
            }
            foreach (var item in continents)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"    {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
