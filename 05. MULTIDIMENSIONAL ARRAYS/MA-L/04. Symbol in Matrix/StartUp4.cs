

namespace _04._Symbol_in_Matrix
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            if (size > 0)
            {
                var table = new char[size, size];
                for (int i = 0; i < size; i++)
                {
                    var line = Console.ReadLine();
                    if (line.Length == size)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            table[i, j] = line[j];
                        }
                    }
                }
                var symbol = char.Parse(Console.ReadLine());
                var exist = false;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (table[i, j] == symbol)
                        {
                            Console.WriteLine($"({ i}, { j})");
                            exist = true;
                            break;
                        }
                    }
                    if (exist) break;
                }
                if (!exist) Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
