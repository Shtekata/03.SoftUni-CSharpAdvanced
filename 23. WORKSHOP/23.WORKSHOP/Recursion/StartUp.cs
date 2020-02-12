namespace Recursion
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            Console.WriteLine(Sum(input));

            //var number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Fatoriel(number));

            //Print("fgh","ghj","jkl");
        }
        private static int Sum(int[] arr)
        {
            return Sum(arr, 0);
        }
        private static int Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }
            return arr[index] + Sum(arr, ++index);
        }
        private static long Fatoriel(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Fatoriel(--number);
        }
        private static void Print(params string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
