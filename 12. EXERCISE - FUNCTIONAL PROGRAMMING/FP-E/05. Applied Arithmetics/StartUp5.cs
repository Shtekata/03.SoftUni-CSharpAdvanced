
namespace _05._Applied_Arithmetics
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var command = Console.ReadLine();

            Func<int, int> adding = x => x + 1;
            Func<int, int> subtracting = x => x - 1;
            Func<int, int> multiplying = x => x * 2;
            Action<int[]> printing = x => Console.WriteLine(string.Join(" ",x));

            while (command!="end")
            {
                if (command == "add")
                {
                    input = input.Select(adding).ToArray();
                }
                else if (command == "multiply")
                {
                    input = input.Select(multiplying).ToArray();
                }
                else if (command == "subtract")
                {
                    input = input.Select(subtracting).ToArray();
                }
                else if (command == "print")
                {
                    printing(input);
                }
                command = Console.ReadLine();
            }
        }
    }
}
