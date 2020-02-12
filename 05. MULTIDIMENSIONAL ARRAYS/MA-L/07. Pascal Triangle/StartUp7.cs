
namespace _07._Pascal_Triangle
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var triangle = new long[size][];
            for (int i = 0; i < size; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            foreach (var item in triangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
