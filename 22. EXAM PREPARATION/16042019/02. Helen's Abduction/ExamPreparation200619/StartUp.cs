
namespace ExamPreparation200619
{
    using System;
    using System.Linq;

    public class StartUp
    {
        private static int yP;
        private static int xP;
        private static char[][] matrix;
        private static int energy;
        private static bool succeed;
        public static void Main(string[] args)
        {
            energy = int.Parse(Console.ReadLine());

            var size = int.Parse(Console.ReadLine());

            matrix = new char[size][];

            succeed = true;

            var foundP = false;

            for (int i = 0; i < size; i++)
            {
                var line = Console.ReadLine()
                    .ToCharArray();
                matrix[i] = line;

                if (!foundP)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][j] = line[j];
                        if (matrix[i][j] == 'P')
                        {
                            yP = i;
                            xP = j;
                            foundP = true;
                        }
                    }
                }
            }
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var command = input[0];
                var sY = int.Parse(input[1]);
                var sX = int.Parse(input[2]);

                matrix[sY][sX] = 'S';

                matrix[yP][xP] = '-';

                Move(command);
                
                energy--;
                if (matrix[yP][xP] == 'S')
                {
                    matrix[yP][xP] = '-';
                    energy -= 2;
                }
                else if (matrix[yP][xP] == 'H')
                {
                    matrix[yP][xP] = '-';
                    break;
                }
                if (energy <= 0)
                {
                    succeed = false;
                    matrix[yP][xP] = 'X';
                    break;
                }
            }
            Print();
        }

        private static void Print()
        {
            if (succeed)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {yP};{xP}.");
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }

        private static void Move(string command)
        {
            switch (command)
            {
                case "right":
                    if (xP + 1 < matrix[yP].Length)
                    {
                        xP++;
                    }
                    break;
                case "left":
                    if (xP > 0)
                    {
                        xP--;
                    }
                    break;
                case "down":
                    if (yP + 1 < matrix.Length)
                    {
                        yP++;
                    }
                    break;
                case "up":
                    if (yP > 0)
                    {
                        yP--;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
