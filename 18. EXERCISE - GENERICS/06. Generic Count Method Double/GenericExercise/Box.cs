using System;
using System.Collections.Generic;
using System.Text;

namespace GenericExercise
{
   public class Box<T>
        where T : IComparable<T>
    {
        public List<T> collect;

        public Box()
        {
            collect = new List<T>();
        }

        public int Counter { get; private set; }

        public void Add(T item)
        {
            collect.Add(item);
        }

        public int Compare(T something)
        {
            foreach (var item in collect)
            {
                if (item.CompareTo(something) > 0)
                {
                    Counter++;
                }
            }

            return Counter;
        }
    }
}
