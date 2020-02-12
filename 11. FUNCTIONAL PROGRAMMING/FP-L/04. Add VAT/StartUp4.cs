
namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
