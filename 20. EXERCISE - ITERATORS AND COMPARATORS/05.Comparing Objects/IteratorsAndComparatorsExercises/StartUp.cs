
namespace IteratorsAndComparatorsExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);


                input = Console.ReadLine();
            }

            var n = int.Parse(Console.ReadLine());

            var countOfMatches = 1;
            var countOfNotEqualPeople = 0;

            var targetPerson = people[n - 1];

            foreach (var item in people)
            {
                if (targetPerson == item)
                {
                    continue;
                }

                if (targetPerson.CompareTo(item) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqualPeople++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqualPeople} {people.Count}");
            }
        }
    }
}
