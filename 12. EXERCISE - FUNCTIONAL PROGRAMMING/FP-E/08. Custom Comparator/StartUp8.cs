
namespace _08._Custom_Comparator
{
    using System;
    using System.Linq;

    public class StartUp8
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> sort = (x, y) => (x % 2 == 0 && y % 2 != 0) ? -1
                 : (x % 2 != 0 && y % 2 == 0) ? 1
                     : (x > y) ? 1
                     : (x < y) ? -1
                     : 0;

            Array.Sort(input, (x, y) => sort(x, y));

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
