
namespace _07._SoftUni_Party
{
    using System;
    using System.Collections.Generic;

    public class StartUp7
    {
       public static void Main()
        {
            var vip = new HashSet<string>();
            var regular = new HashSet<string>();
            string input;
            var number = 0;
            while ((input=Console.ReadLine())?.ToLower()!="party")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Add(input);
                    number++;
                }
                else
                {
                    regular.Add(input);
                    number++;
                }
            }
            while ((input=Console.ReadLine())?.ToLower()!="end")
            {
                if (char.IsDigit(input[0]))
                {
                    vip.Remove(input);
                    number--;
                }
                else
                {
                    regular.Remove(input);
                    number--;
                }
            }
            Console.WriteLine(number);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}
