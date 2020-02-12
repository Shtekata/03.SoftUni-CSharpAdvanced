
namespace _01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class StartUp1
    {
       public static void Main()
        {
            var usernames = new HashSet<string>();
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
