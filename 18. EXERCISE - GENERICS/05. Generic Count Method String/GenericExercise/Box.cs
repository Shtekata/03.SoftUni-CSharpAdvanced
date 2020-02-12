using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExercise
{
   public class Box<T>
        where T : IComparable<T>
    {
        public List<T> myCollection;

        public Box()
        {
            myCollection = new List<T>();
        }

        public int counter { get; private set; }

        public void Add(T item)
        {
            myCollection.Add(item);
        }

        public int Compare(T something)
        {
            foreach (var item in myCollection)
            {
                if (item.CompareTo(something) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
