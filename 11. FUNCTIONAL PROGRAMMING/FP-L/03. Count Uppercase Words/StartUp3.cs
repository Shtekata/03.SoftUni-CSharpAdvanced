
namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class StartUp3
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(AlaBala)
                .Select(x => { Console.WriteLine(x); return x; })
                .Count();
        }
        public static Func<string, bool> AlaBala = x => x[0] == x.ToUpper()[0];
    }
}
