
namespace _04._Even_Times
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
       public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            var set2 = new HashSet<string>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                if (set.Contains(input))
                {
                    if (!set2.Contains(input))
                    {
                        set2.Add(input);
                    }
                    else
                    {
                        set2.Remove(input);
                    }
                }
                else
                {
                    set.Add(input);
                }
            }
            Console.WriteLine(string.Join(" ",set2));
        }
    }
}
