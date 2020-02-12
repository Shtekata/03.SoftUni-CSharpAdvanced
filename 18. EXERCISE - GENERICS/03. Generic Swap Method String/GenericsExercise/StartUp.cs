
namespace GenericsExercise
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main(string[] args)
        {
            var myBox = new Box<string>();

            var numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                var text = Console.ReadLine();

                myBox.Add(text);
            }

            var swap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstIndex = swap[0];

            var secondIndex = swap[1];

            myBox.Swap(firstIndex, secondIndex);

            var output = myBox.ToString();

            Console.WriteLine(output);
        }
    }
}
