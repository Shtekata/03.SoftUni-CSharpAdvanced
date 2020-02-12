namespace TronRacers
{
    using System;
    using System.Linq;

    public class Program
    {
        private static int yF;
        private static int xF;
        private static int yS;
        private static int xS;
        private static char[][] matrix;
        public static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());

            matrix = new char[numb][];

            for (int i = 0; i < numb; i++)
            {
                var temp = Console.ReadLine()
                    .ToCharArray();

                matrix[i] = temp;
            }

            Coordinates('f');
            Coordinates('s');

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var commandF = input[0];
                var commandS = input[1];

                var crashOne = Person('f', commandF);
                if (!crashOne)
                {
                    break;
                }
                var crashTwo = Person('s', commandS);

                if (!crashTwo)
                {
                    break;
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(string.Empty, item));
            }
        }

        public static void Coordinates(char seek)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Contains(seek))
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == seek)
                        {
                            if (seek == 'f')
                            {
                                yF = i;
                                xF = j;
                            }
                            else
                            {
                                yS = i;
                                xS = j;
                            }
                            return;
                        }
                    }
                }
            }
        }

        public static bool Person(char inp, string commandF)
        {
            var result = true;

            switch (commandF)
            {
                case "right":
                    {
                        result = Right(inp);
                    }
                    break;
                case "left":
                    {
                        result = Left(inp);
                    }
                    break;
                case "down":
                    {
                        result = Down(inp);
                    }
                    break;
                case "up":
                    {
                        result = Up(inp);
                    }
                    break;
            }
            return result;
        }

        public static bool Right(char symb)
        {
            var result = true;
            if (symb == 'f')
            {
                if (xF < matrix[yF].Length - 1)
                {
                    if (matrix[yF][xF + 1] == '*')
                    {
                        matrix[yF][xF + 1] = symb;
                        xF++;
                    }
                    else
                    {
                        result = false;
                        matrix[yF][xF + 1] = 'x';
                    }
                }
                else
                {
                    if (matrix[yF][0] == '*')
                    {
                        matrix[yF][0] = symb;
                        xF = 0;
                    }
                    else
                    {
                        result = false;
                        matrix[yF][0] = 'x';
                    }
                }
                return result;
            }
            else
            {
                if (xS < matrix[yS].Length - 1)
                {
                    if (matrix[yS][xS + 1] == '*')
                    {
                        matrix[yS][xS + 1] = symb;
                        xS++;
                    }
                    else
                    {
                        result = false;
                        matrix[yS][xS + 1] = 'x';
                    }
                }
                else
                {
                    if (matrix[yS][0] == '*')
                    {
                        matrix[yS][0] = symb;
                        xS = 0;
                    }
                    else
                    {
                        result = false;
                        matrix[yS][0] = 'x';
                    }
                }
                return result;
            }
        }

        public static bool Left(char symb)
        {
            var result = true;
            if (symb == 'f')
            {
                if (xF > 0)
                {
                    if (matrix[yF][xF - 1] == '*')
                    {
                        matrix[yF][xF - 1] = symb;
                        xF--;
                    }
                    else
                    {
                        result = false;
                        matrix[yF][xF - 1] = 'x';
                    }
                }
                else
                {
                    if (matrix[yF][matrix[xF].Length - 1] == '*')
                    {
                        matrix[yF][matrix[xF].Length - 1] = symb;
                        xF = matrix[yF].Length - 1;
                    }
                    else
                    {
                        result = false;
                        matrix[yF][matrix[xF].Length - 1] = 'x';
                    }
                }
                return result;
            }
            else
            {
                if (xS > 0)
                {
                    if (matrix[yS][xS - 1] == '*')
                    {
                        matrix[yS][xS - 1] = symb;
                        xS--;
                    }
                    else
                    {
                        result = false;
                        matrix[yS][xS - 1] = 'x';
                    }
                }
                else
                {
                    if (matrix[yS][matrix[xS].Length - 1] == '*')
                    {
                        matrix[yS][matrix[xS].Length - 1] = symb;
                        xS = matrix[yS].Length - 1;
                    }
                    else
                    {
                        result = false;
                        matrix[yS][matrix[xS].Length - 1] = 'x';
                    }
                }
                return result;
            }
        }

        public static bool Down(char symb)
        {
            var result = true;
            if (symb == 'f')
            {
                if (yF < matrix.Length - 1)
                {
                    if (matrix[yF + 1][xF] == '*')
                    {
                        matrix[yF + 1][xF] = symb;
                        yF++;
                    }
                    else
                    {
                        result = false;
                        matrix[yF + 1][xF] = 'x';
                    }
                }
                else
                {
                    if (matrix[0][xF] == '*')
                    {
                        matrix[0][xF] = symb;
                        yF = 0;
                    }
                    else
                    {
                        result = false;
                        matrix[0][xF] = 'x';
                    }
                }
                return result;
            }
            else
            {
                if (yS < matrix.Length - 1)
                {
                    if (matrix[yS + 1][xS] == '*')
                    {
                        matrix[yS + 1][xS] = symb;
                        yS++;
                    }
                    else
                    {
                        result = false;
                        matrix[yS + 1][xS] = 'x';
                    }
                }
                else
                {
                    if (matrix[0][xS] == '*')
                    {
                        matrix[0][xS] = symb;
                        yS = 0;
                    }
                    else
                    {
                        result = false;
                        matrix[0][xS] = 'x';
                    }
                }
                return result;
            }
        }

        public static bool Up(char symb)
        {
            var result = true;
            if (symb == 'f')
            {
                if (yF > 0)
                {
                    if (matrix[yF - 1][xF] == '*')
                    {
                        matrix[yF - 1][xF] = symb;
                        yF--;
                    }
                    else
                    {
                        result = false;
                        matrix[yF - 1][xF] = 'x';
                    }
                }
                else
                {
                    if (matrix[matrix.Length - 1][xF] == '*')
                    {
                        matrix[matrix.Length - 1][xF] = symb;
                        yF = matrix.Length - 1;
                    }
                    else
                    {
                        result = false;
                        matrix[matrix.Length - 1][xF] = 'x';
                    }
                }
                return result;
            }
            else
            {
                if (yS > 0)
                {
                    if (matrix[yS - 1][xS] == '*')
                    {
                        matrix[yS - 1][xS] = symb;
                        yS--;
                    }
                    else
                    {
                        result = false;
                        matrix[yS - 1][xS] = 'x';
                    }
                }
                else
                {
                    if (matrix[matrix.Length - 1][xS] == '*')
                    {
                        matrix[matrix.Length - 1][xS] = symb;
                        yS = matrix.Length - 1;
                    }
                    else
                    {
                        result = false;
                        matrix[matrix.Length - 1][xS] = 'x';
                    }
                }
                return result;
            }
        }
    }
}
