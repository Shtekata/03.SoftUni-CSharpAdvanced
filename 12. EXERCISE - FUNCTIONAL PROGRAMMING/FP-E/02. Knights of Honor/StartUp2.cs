
namespace _02._Knights_of_Honor
{
    using System;
   public class StartUp2
    {
       public static void Main()
        {
            Action<string[]> blaBla = tkp => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", tkp));
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            blaBla(input);
        }
    }
}
