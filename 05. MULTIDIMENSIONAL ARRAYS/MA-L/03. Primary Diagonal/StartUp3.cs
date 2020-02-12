

namespace _03._Primary_Diagonal
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var table = new int[size, size];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    table[i, j] = line[j];
                }
            }
            var sum = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                sum += table[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
