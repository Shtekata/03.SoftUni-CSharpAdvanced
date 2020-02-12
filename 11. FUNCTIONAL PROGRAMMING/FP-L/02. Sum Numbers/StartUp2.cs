
namespace _02._Sum_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(Koko)
                .ToArray();

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Sum());
        }

        public static Func<string, int> Koko = n => Int32.Parse(n);
    }
}
