
namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var vlogger = new Dictionary<string, List<string>>();
            var vloggerCount = new Dictionary<string, int>();
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "Statistics")
            {
                switch (input[1])
                {
                    case "joined":
                        if (!vlogger.ContainsKey(input[0]))
                        {
                            vlogger[input[0]] = new List<string>();
                        }
                        break;
                    case "followed":
                        if (vlogger.ContainsKey(input[0]) && vlogger.ContainsKey(input[2]))
                        {
                            vlogger[input[2]].Add(input[0]);
                            if (!vloggerCount.ContainsKey(input[0]))
                            {
                                vloggerCount[input[0]] = 1;
                            }
                            else vloggerCount[input[0]]++;
                        }
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"The V-logger has a total of {vlogger.Count} vloggers in its logs.");
            var number = 1;
            foreach (var item in vlogger.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{number}. {item.Key} : {item.Value.Count} followers, {vloggerCount[item.Key]} following");
            }
        }
    }
}
