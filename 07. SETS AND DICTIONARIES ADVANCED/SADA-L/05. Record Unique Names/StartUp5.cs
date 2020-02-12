
namespace _05._Record_Unique_Names
{
    using System;
    using System.Collections.Generic;

    public class StartUp5
    {
       public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < number; i++)
            {
                set.Add(Console.ReadLine());
            }
            Console.WriteLine($"{string.Join("\n",set)}");
        }
    }
}
