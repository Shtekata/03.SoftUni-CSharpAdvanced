
namespace _06._Jagget_Array_Modification
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var jaggedTable = new int[size][];
            for (int i = 0; i < jaggedTable.Length; i++)
            {
                var line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jaggedTable[i] = line;
            }
            var command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0].ToLower() != "end")
            {
                var row = int.Parse(command[1]);
                var col = int.Parse(command[2]);
                if (row >= 0 && row < jaggedTable.Length && col >= 0 && col < jaggedTable[row].Length)
                {
                    if (command[0] == "Add")
                    {
                        jaggedTable[row][col] += int.Parse(command[3]);
                    }
                    else jaggedTable[row][col] -= int.Parse(command[3]);
                }
                else Console.WriteLine($"Invalid coordinates");
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            foreach (var item in jaggedTable)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
