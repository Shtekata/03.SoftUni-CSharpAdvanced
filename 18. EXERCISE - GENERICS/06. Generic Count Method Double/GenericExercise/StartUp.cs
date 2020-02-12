
namespace GenericExercise
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            var myCollection = new Box<double>();

            var numb = int.Parse(Console.ReadLine());

            for (int i = 0; i < numb; i++)
            {
                var temp = double.Parse(Console.ReadLine());

                myCollection.Add(temp);
            }

            var compThink = double.Parse(Console.ReadLine());

            var result = myCollection.Compare(compThink);

            Console.WriteLine(result);
        }
    }
}
