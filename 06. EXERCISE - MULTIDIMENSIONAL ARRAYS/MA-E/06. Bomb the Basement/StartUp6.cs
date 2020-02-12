
namespace _06._Bomb_the_Basement
{
    using System;
    using System.Linq;

    public class StartUp6
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[size[0], size[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            var shot = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var y = shot[0];
            var x = shot[1];
            var damage = shot[2];
            var vStepDown = y + damage;
            var xStep = damage;
            var vStepUp = y - damage;
            var xStepLeft = 0;
            var xStepRight = 0;
            if (vStepUp < 0)
            {
                vStepUp = 0;
            }
            for (int i = y; i >= vStepUp; i--)
            {
                xStepLeft = x - xStep;
                if (xStepLeft < 0)
                {
                    xStepLeft = 0;
                }
                xStepRight = x + xStep;
                if (xStepRight >= matrix.GetLength(1))
                {
                    xStepRight = matrix.GetLength(1) - 1;
                }
                for (int j = xStepLeft; j <= xStepRight; j++)
                {
                    matrix[i, j] = 1;
                }
                xStep--;
            }
            xStep = damage - 1;
            if (vStepDown >= matrix.GetLength(0))
            {
                vStepDown = matrix.GetLength(0) - 1;
            }
            for (int i = y + 1; i <= vStepDown; i++)
            {
                xStepLeft = x - xStep;
                if (xStep < 0)
                {
                    xStep = 0;
                }
                xStepRight = x + xStep;
                if (xStepRight >= matrix.GetLength(1))
                {
                    xStepRight = matrix.GetLength(1) - 1;
                }
                for (int j = xStepLeft; j <= xStepRight; j++)
                {
                    matrix[i, j] = 1;
                }
                xStep--;
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[0, i] == 0)
                    {
                        for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                        {
                            matrix[k, i] = matrix[k + 1, i];
                        }
                        matrix[matrix.GetLength(0) - 1, i] = 0;
                    }
                    else break;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
