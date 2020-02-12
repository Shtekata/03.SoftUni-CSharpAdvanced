
namespace _11._The_Party_Reservation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp11
    {
       public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var filters = new List<string>();

            var command = Console.ReadLine();

            while (command!="Print")
            {
                var commandNew = command.Split(';');
                var commandFirst = commandNew[0];
                var commandInfo = $"{commandNew[1]};{commandNew[2]}";

                if (commandFirst == "Add filter")
                {
                    filters.Add(commandInfo);
                }
                else
                {
                    filters.Remove(commandInfo);
                }
                command = Console.ReadLine();
            }
            foreach (var item in filters)
            {
                var info = item.Split(';');
                var type = info[0];
                var parameter = info[1];

                Func<string, string, bool> starts = (x, y) => x.StartsWith(y);
                Func<string, string, bool> ends = (x, y) => x.EndsWith(y);
                Func<int, string, bool> length = (x, y) => x == y.Length;
                Func<string, string, bool> contains = (x, y) => x.Contains(y);

                if(type=="Starts with")
                {
                    input = input.Where(x => !starts(x, parameter))
                        .ToArray();
                }
                else if(type=="Ends with")
                {
                    input = input.Where(x => !ends(x, parameter))
                        .ToArray();
                }
                else if (type == "Length")
                {
                    var parameterNew = int.Parse(parameter);
                    input = input.Where(x => !length(parameterNew, x))
                        .ToArray();
                }
                else if (type == "Contains")
                {
                    input = input.Where(x => !contains(x, parameter))
                        .ToArray();
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
