
namespace _05._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class StartUp5
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var table = new int[size[0], size[1]];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                var line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = line[j];
                }
            }
            var maxNumber = int.MinValue;
            var x = -1;
            var y = -1;
            for (int i = 0; i < table.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < table.GetLength(1) - 1; j++)
                {
                    var sum = table[i, j] + table[i, j + 1] + table[i + 1, j] + table[i + 1, j + 1];
                    if (sum > maxNumber)
                    {
                        maxNumber = sum;
                        x = i;
                        y = j;
                    }
                }
            }
            Console.WriteLine($"{table[x, y]} {table[x, y + 1]}\n{table[x + 1, y]} {table[x + 1, y + 1]}\n{maxNumber}");
        }
    }
}
