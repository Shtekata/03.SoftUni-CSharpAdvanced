using System;

namespace DefiningClasses
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var personOne = new Person();
            Console.WriteLine($"{personOne.Name}, {personOne.Age}");

            var personTwo = new Person(15);
            Console.WriteLine($"{personTwo.Name}, {personTwo.Age}");

            var personThree = new Person("Gosho",35);
            Console.WriteLine($"{personThree.Name}, {personThree.Age}");
        }
    }
}
