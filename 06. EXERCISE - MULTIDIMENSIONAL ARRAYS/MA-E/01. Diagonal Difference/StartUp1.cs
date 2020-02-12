
namespace _01._Diagonal_Difference
{
    using System;
    using System.Linq;

    public class StartUp1
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var table = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < size; j++)
                {
                    table[i, j] = line[j];
                }
            }
            var sumFirst = 0;
            var sumSecond = 0;
            for (int i = 0; i < size; i++)
            {
                sumFirst += table[i, i];
                sumSecond += table[size - 1 - i, i];
            }
            Console.WriteLine(Math.Abs(sumFirst - sumSecond));
        }
    }
}
