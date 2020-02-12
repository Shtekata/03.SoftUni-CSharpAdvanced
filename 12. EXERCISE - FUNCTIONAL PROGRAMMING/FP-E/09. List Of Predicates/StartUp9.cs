
namespace _09._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp9
    {
       public static void Main()
        {
            var maxNumber = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            var predicates = new List<Predicate<int>>();
            var numbers = new List<int>();

            foreach (var item in dividers)
            {
                predicates.Add(x => x % item == 0);
            }

            for (int i = 1; i <= maxNumber; i++)
            {
                var isTrue = true;
                foreach (var item in predicates)
                {
                    if (!item(i))
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    numbers.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
