using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var familyMembers = new Family();

            for (int i = 0; i < number; i++)
            {
                var person = Console.ReadLine()
                    .Split();
                var name = person[0];
                var age = int.Parse(person[1]);
                var member = new Person(name, age);
                familyMembers.AddMember(member);
            }
            var older = familyMembers.GetOldestMember();

            Console.WriteLine($"{older.Name} {older.Age}");
        }
    }
}
