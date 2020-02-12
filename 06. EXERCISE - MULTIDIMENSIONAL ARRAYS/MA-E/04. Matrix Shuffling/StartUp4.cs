
namespace _04._Matrix_Shuffling
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new string[size[0], size[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var newInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                var swap = true;
                if (newInput.Length == 5 && newInput[0] == "swap")
                {
                    var x1 = int.Parse(newInput[1]);
                    var y1 = int.Parse(newInput[2]);
                    var x2 = int.Parse(newInput[3]);
                    var y2 = int.Parse(newInput[4]);
                    if (x1 <= matrix.GetLength(0) && x2 <= matrix.GetLength(0)
                        && y1 <= matrix.GetLength(1) && y2 <= matrix.GetLength(1)
                        && x1 >= 0 && x2 >= 0 && y1 >= 0 && y2 >= 0)
                    {
                        var temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else swap = false;
                }
                else swap = false;
                if (!swap)
                {
                    Console.WriteLine($"Invalid input!");
                }
            }
        }
    }
}
