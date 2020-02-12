
namespace Delegates
{
    using System;
   public class StartUp
    {
        public delegate void Print(int x);
        static void Main(string[] args)
        {
            Print sum = sumPlusOne;
            sum(8);
            Print text = sumToString;
            text(9);
        }

        public static void sumPlusOne(int y)
        {
            Console.WriteLine(y+1);
        }

        public static void sumToString(int h)
        {
            Console.WriteLine($"{h} - string");
        }
    }
}
