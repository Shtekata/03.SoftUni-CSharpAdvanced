
namespace GenericExercise
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            var myNewCollection = new Box<string>();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();

                myNewCollection.Add(input);
            }

            var inInput = Console.ReadLine();

            myNewCollection.Compare(inInput);

            var result = myNewCollection.counter;

            Console.WriteLine(result);
        }
    }
}
