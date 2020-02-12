
namespace _02._Average_Student_Grades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numberOfGrades = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < numberOfGrades; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (grades.ContainsKey(input[0]))
                {
                    grades[input[0]].Add(double.Parse(input[1]));
                }
                else
                {
                    grades.Add(input[0], new List<double>() { double.Parse(input[1]) });
                }
            }
            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x => x.ToString("f")))} (avg: {item.Value.Average():f})");
            }
        }
    }
}
