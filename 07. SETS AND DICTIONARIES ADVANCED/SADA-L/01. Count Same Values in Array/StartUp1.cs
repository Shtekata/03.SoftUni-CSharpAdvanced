
namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var values = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!values.ContainsKey(input[i]))
                {
                    values[input[i]] = 1;
                }
                else
                {
                    values[input[i]]++;
                }
            }
            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
