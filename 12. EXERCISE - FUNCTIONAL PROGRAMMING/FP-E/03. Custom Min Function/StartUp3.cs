
namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> minNumber = inputNew =>
            {
                var min = int.MaxValue;
                foreach (var item in inputNew)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Action<int> printNumber = minValue => Console.WriteLine(minValue);
            printNumber(minNumber(input));
        }
    }
}
