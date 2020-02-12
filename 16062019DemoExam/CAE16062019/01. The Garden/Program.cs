using System;
using System.Linq;
using System.Text;

namespace _01._The_Garden
{
    public class Program
    {
        private static int y;
        private static int x;
        private static int carrots = 0;
        private static int potatoes = 0;
        private static int lettuce = 0;
        private static int harmedVegetables = 0;
        private static string[][] field;
        private static string[] splitInput;
        public static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());
            field = new string[numb][];

            for (int i = 0; i < numb; i++)
            {
                var line = Console.ReadLine()
                    .Split()
                    .ToArray();
                    
                field[i] = line;
            }

            var input = Console.ReadLine();

            while (input.ToLower()!="end of harvest")
            {
                splitInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = splitInput[0];
                y = int.Parse(splitInput[1]);
                x = int.Parse(splitInput[2]);

                if (command == "Harvest")
                {
                    Harvest();
                }
                else if (command == "Mole")
                {
                    Mole();
                }
                input = Console.ReadLine();
            }

            foreach (var item in field)
            {
                Console.WriteLine(string.Join(" ", item));
            }

            Console.WriteLine(Print());
        }

        private static string Print()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Carrots: {carrots}");
            sb.AppendLine($"Potatoes: {potatoes}");
            sb.AppendLine($"Lettuce: {lettuce}");
            sb.AppendLine($"Harmed vegetables: {harmedVegetables}");

            return sb.ToString().TrimEnd();
        }
        private static bool inRange()
        {
            if (y >= 0 && y < field.Length && x >= 0 && x < field[y].Length)
            {
                return true;
            }
            else return false;
        }

        private static void isHarmed(int a, int b)
        {
            if (field[a][b] == "C" || field[a][b] == "P" || field[a][b] == "L")
            {
                harmedVegetables++;
            }
        }

        private static void Mole()
        {
            var direction = splitInput[3];

            if (inRange())
            {
                if (direction.ToLower() == "right")
                {
                    for (int i = x; i < field[y].Length; i+=2)
                    {
                        if (i == field[y].Length) break;
                        isHarmed(y, i);
                        field[y][i] = " ";
                    }
                }
                else if (direction.ToLower() == "left")
                {
                    for (int i = x; i >= 0; i-=2)
                    {
                        if (i < 0) break;
                        isHarmed(y, i);
                        field[y][i] = " ";
                    }
                }
                else if (direction.ToLower() == "down")
                {
                    for (int i = y; i < field.Length; i+=2)
                    {
                        if (i == field.Length) break;
                        isHarmed(i, x);
                        field[i][x] = " ";
                    }
                }
                else if (direction.ToLower() == "up")
                {
                    for (int i = y; i >= 0; i-=2)
                    {
                        if (i < 0) break;
                        isHarmed(i, x);
                        field[i][x] = " ";
                    }
                }
            }
        }

        private static void Harvest()
        {
            if (inRange())
            {
                if (field[y][x] == "C")
                {
                    carrots++;
                }
                else if (field[y][x] == "P")
                {
                    potatoes++;
                }
                else if (field[y][x] == "L")
                {
                    lettuce++;
                }
                field[y][x] = " ";
            }
        }
    }
}
