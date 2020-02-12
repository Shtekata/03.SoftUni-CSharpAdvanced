
namespace _12._TriFunction
{
    using System;
    using System.Linq;

    public class StartUp12
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var input = Console.ReadLine()
                .Split(" ");

            Func<string, int, bool> allright = (x, y) => x.Sum(s => s) >= y;

            Func<string[], Func<string, int, bool>, string> result = (x, y) => x.FirstOrDefault(z => y(z, number));

            var output = result(input, allright);

            Console.WriteLine(output);
        }
    }
}
