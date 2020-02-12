
namespace GenericsExercise
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            var newBox = new Box<int>();

            var numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                var item = int.Parse(Console.ReadLine());

                newBox.Add(item);
            }

            var output = newBox.ToString();

            Console.WriteLine(output);
        }
    }
}
