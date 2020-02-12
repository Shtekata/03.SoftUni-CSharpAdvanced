
namespace _07._Knight_Game
{
    using System;
    using System.Linq;

    public class StartUp7
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new char[size, size];
            for (int i = 0; i < size; i++)
            {
                var line = Console.ReadLine().Trim().ToCharArray();
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            var number = 0;
            var maxNumber = 0;
            var y = -1;
            var x = -1;
            while (true)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        var currentNumber = 0;
                        if (matrix[i, j] == 'K')
                        {
                            if (i - 2 >= 0 && j - 1 >= 0 && matrix[i - 2, j - 1] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i - 2 >= 0 && j + 1 <= matrix.GetLength(1) - 1 && matrix[i - 2, j + 1] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i - 1 >= 0 && j - 2 >= 0 && matrix[i - 1, j - 2] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i - 1 >= 0 && j + 2 <= matrix.GetLength(1) - 1 && matrix[i - 1, j + 2] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i + 1 <= matrix.GetLength(0) - 1 && j - 2 >= 0 && matrix[i + 1, j - 2] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i + 1 <= matrix.GetLength(0) - 1 && j + 2 <= matrix.GetLength(1) - 1 && matrix[i + 1, j + 2] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i + 2 <= matrix.GetLength(0) - 1 && j - 1 >= 0 && matrix[i + 2, j - 1] == 'K')
                            {
                                currentNumber++;
                            }
                            if (i + 2 <= matrix.GetLength(0) - 1 && j + 1 <= matrix.GetLength(1) - 1 && matrix[i + 2, j + 1] == 'K')
                            {
                                currentNumber++;
                            }
                        }
                        if (currentNumber > maxNumber)
                        {
                            maxNumber = currentNumber;
                            y = i;
                            x = j;
                        }
                    }
                }
                if (maxNumber > 0)
                {
                    maxNumber = 0;
                    matrix[y, x] = '0';
                    number++;
                }
                else break;
            }
            Console.WriteLine(number);
        }
    }
}
