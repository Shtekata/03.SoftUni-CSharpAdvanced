
namespace GenericsExercise
{
    using System;
    public class StartUp
    {
       public static void Main(string[] args)
        {
            var box = new Box<string>();

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                box.Add(Console.ReadLine());
            }
            
            Console.WriteLine(box.ToString());
        }
    }
}
