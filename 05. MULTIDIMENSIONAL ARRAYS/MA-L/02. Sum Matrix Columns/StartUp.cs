

namespace _02._Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    public class StartUp
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
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = line[j];
                }
            }
            for (int i = 0; i < table.GetLength(1); i++)
            {
                var sum = 0;
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    sum += table[j, i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
