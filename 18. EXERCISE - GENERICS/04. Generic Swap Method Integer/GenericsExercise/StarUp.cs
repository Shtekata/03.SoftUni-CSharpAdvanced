
namespace GenericsExercise
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main(string[] args)
        {
            var curentBox = new Box<int>();

            var numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                var temp = int.Parse(Console.ReadLine());

                curentBox.Add(temp);
            }

            var swap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstIndex = swap[0];
            var secondIndex = swap[1];

            curentBox.Swap(firstIndex, secondIndex);

            var output = curentBox.ToString();

            Console.WriteLine(output);
        }
    }
}
