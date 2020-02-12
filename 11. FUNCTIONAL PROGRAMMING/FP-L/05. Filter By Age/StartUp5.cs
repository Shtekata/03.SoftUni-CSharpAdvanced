
namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < number; i++)
            {
                var person = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                people.Add(new KeyValuePair<string, int>(person[0], int.Parse(person[1])));
            }
                var filter = Console.ReadLine();
                var age = int.Parse(Console.ReadLine());
                var printPatern = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                people
                    .Where(x => filter == "younger" ? x.Value < age : x.Value >= age)
                    .ToList()
                    .ForEach(x => Printer(x, printPatern));
            
        }
        static void Printer(KeyValuePair<string, int> alaBala, string[] baBa)
        {
            if (baBa.Length == 2)
            {
                Console.WriteLine(baBa[0] == "name" ? $"{alaBala.Key} - {alaBala.Value}" : $"{alaBala.Value} - {alaBala.Key}");
            }
            else
            {
                Console.WriteLine(baBa[0] == "name" ? $"{alaBala.Key}" : $"{alaBala.Value}");
            }
        }

    }
}
