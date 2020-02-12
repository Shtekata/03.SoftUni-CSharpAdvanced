
namespace _03._Maximal_Sum
{
    using System;
    using System.Linq;

    public class StartUp3
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var table = new int[size[0], size[1]];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = line[j];
                }
            }
            var maxSum = int.MinValue;
            var x = -1;
            var y = -1;
            for (int i = 0; i < table.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < table.GetLength(1) - 2; j++)
                {
                    var currentSum = table[i, j] + table[i, j + 1] + table[i, j + 2]
                        + table[i + 1, j] + table[i + 1, j + 1] + table[i + 1, j + 2]
                        + table[i + 2, j] + table[i + 2, j + 1] + table[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        x = i;
                        y = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}\n{table[x, y]} {table[x, y + 1]} {table[x, y + 2]}\n" +
                $"{table[x + 1, y]} {table[x + 1, y + 1]} {table[x + 1, y + 2]}\n" +
                $"{table[x + 2, y]} {table[x + 2, y + 1]} {table[x + 2, y + 2]}");
        }
    }
}
