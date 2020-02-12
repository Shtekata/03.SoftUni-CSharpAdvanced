using System;

namespace DefiningClasses
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            var personOne = new Person();
            personOne.Name = "Pesho";
            personOne.Age = 20;

            var personTwo = new Person();
            personTwo.Name = "Gosho";
            personTwo.Age = 18;

            var personThree = new Person();
            personThree.Name = "Stamat";
            personThree.Age = 43;
        }
    }
}
