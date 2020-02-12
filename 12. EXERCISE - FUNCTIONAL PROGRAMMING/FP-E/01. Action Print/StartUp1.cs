
namespace _01._Action_Print
{
    using System;
   public class StartUp1
    {
       public static void Main()
        {
            Action<string[]> AlaBala = kukuruku => Console.WriteLine(string.Join(Environment.NewLine, kukuruku));

            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            AlaBala(input);
        }
    }
}
