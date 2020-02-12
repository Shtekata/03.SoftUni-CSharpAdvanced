
namespace _04._Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp4
    {
       public static void Main()
        {
            var range = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var minValue = range[0];
            var maxValue = range[1];
            var type = Console.ReadLine()
                .ToLower();

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;

            var numbers = new List<int>();

            for (int i = minValue; i <= maxValue; i++)
            {
                numbers.Add(i);
            }

            if (type == "even")
            {
                numbers = numbers
                    .Where(x => isEven(x))
                    .ToList();
            }
            else
            {
                numbers = numbers
                    .Where(x => isOdd(x))
                    .ToList();
            }
            Action<List<int>> printNumbers = numb => Console.WriteLine(string.Join(" ", numb));
            printNumbers(numbers);
        }
    }
}
