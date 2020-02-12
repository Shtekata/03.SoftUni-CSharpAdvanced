
namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp2
    {
       public static void Main()
        {
            var hashSet1 = new HashSet<int>();
            var hashSet2 = new HashSet<int>();
            var hashSet3 = new HashSet<int>();

            var input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input[0]; i++)
            {
                hashSet1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (hashSet1.Contains(number))
                {
                    hashSet2.Add(number);
                }
            }
            foreach (var item in hashSet1)
            {
                if (hashSet2.Contains(item))
                {
                    hashSet3.Add(item);
                }
            }
            Console.WriteLine($"{string.Join(" ", hashSet3)}");
        }
    }
}
