namespace _03._ThirdTask
{
    using System;
    public class Program
    {
        public static int yS;
        public static int xS;
        public static int yO1 = -1;
        public static int xO1 = -1;
        public static int yO2 = -1;
        public static int xO2 = -1;
        public static char[][] matrix;
        public static int starPower = 0;
        public static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());
            matrix = new char[numb][];

            for (int i = 0; i < matrix.Length; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                matrix[i] = input;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'S')
                    {
                        yS = i;
                        xS = j;
                    }
                    else if (input[j] == 'O')
                    {
                        if (yO1 == -1 && xO1 == -1)
                        {
                            yO1 = i;
                            xO1 = j;
                        }
                        else
                        {
                            yO2 = i;
                            xO2 = i;
                        }
                    }
                }
            }
            
            while (true)
            {
                var command = Console.ReadLine();
                if (Move(command))
                {
                    MoveOn();
                    if (starPower >= 50)
                    {
                        break;
                    }

                }
                else break;
            }

            if (inRange())
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            Console.WriteLine($"Star power collected: {starPower}");
            Print();
        }

        private static void MoveOn()
        {
                if (matrix[yS][xS] == '-')
                {
                    matrix[yS][xS] = 'S';
                }
                else if (matrix[yS][xS] == '0')
                {
                    matrix[yS][xS] = 'S';
                }
                else if (matrix[yS][xS] == '1')
                {
                    matrix[yS][xS] = 'S';
                    starPower++;
                }
                else if (matrix[yS][xS] == '2')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 2;
                }
                else if (matrix[yS][xS] == '3')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 3;
                }
                else if (matrix[yS][xS] == '4')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 4;
                }
                else if (matrix[yS][xS] == '5')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 5;
                }
                else if (matrix[yS][xS] == '6')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 6;
                }
                else if (matrix[yS][xS] == '7')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 7;
                }
                else if (matrix[yS][xS] == '8')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 8;
                }
                else if (matrix[yS][xS] == '9')
                {
                    matrix[yS][xS] = 'S';
                    starPower += 9;
                }
                else if (matrix[yS][xS] == 'O')
                {
                    if (yS == yO1 && xS == xO1)
                    {
                        matrix[yS][xS] = '-';
                        matrix[yO2][xO2] = 'S';
                        yS = yO2;
                        xS = xO2;
                    }
                    else
                    {
                        matrix[yS][xS] = '-';
                        matrix[yO1][xO1] = 'S';
                        yS = yO1;
                        xS = xO1;
                    }
                }
        }

        private static void Print()
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }

        private static bool Move(string command)
        {
            switch (command)
            {
                case "right":
                    {
                        matrix[yS][xS] = '-';
                        xS++;
                        return inRange();
                    }
                case "left":
                    {
                        matrix[yS][xS] = '-';
                        xS--;
                        return inRange();
                    }
                case "down":
                    {
                        matrix[yS][xS] = '-';
                        yS++;
                        return inRange();
                    }
                case "up":
                    {
                        matrix[yS][xS] = '-';
                        yS--;
                        return inRange();
                    }
            }
            return false;
        }

        private static bool inRange()
        {
            if (yS >= 0 && yS < matrix.Length && xS >= 0 && xS < matrix[yS].Length)
            {
                return true;
            }
            else return false;
        }
    }
}
