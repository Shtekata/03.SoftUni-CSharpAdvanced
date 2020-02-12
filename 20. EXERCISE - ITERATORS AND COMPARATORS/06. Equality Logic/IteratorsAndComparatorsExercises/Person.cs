using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsExercises
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            var result = Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }

            return result;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode() + (257 * 53);
        }

        public override bool Equals(object obj)
        {
            return Name == ((Person)obj).Name && Age == ((Person)obj).Age;
        }
    }
}
