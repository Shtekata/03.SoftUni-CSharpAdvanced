using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise
{
    public class Box<T>
    {
        public List<T> collection;

        public Box()
        {
            collection = new List<T>();
        }

        public void Add(T item)
        {
            collection.Add(item);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in collection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
