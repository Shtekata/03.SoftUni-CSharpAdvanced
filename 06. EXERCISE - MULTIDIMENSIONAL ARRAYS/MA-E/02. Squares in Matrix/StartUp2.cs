
namespace _02._Squares_in_Matrix
{
    using System;
    using System.Linq;

    public class StartUp2
    {
       public static void Main()
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var table = new char[size[0], size[1]];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = line[j];
                }
            }
            var count = 0;
            for (int i = 0; i < table.GetLength(0)-1; i++)
            {
                for (int j = 0; j < table.GetLength(1)-1; j++)
                {
                    if (table[i, j] == table[i, j + 1] && table[i + 1, j] == table[i + 1, j + 1] && table[i, j] == table[i + 1, j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
