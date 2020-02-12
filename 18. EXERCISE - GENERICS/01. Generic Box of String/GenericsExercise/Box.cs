using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise
{
    public class Box<T>
    {
        private List<T> temp;

        public Box()
        {
            temp = new List<T>();
        }

        public void Add(T item)
        {
            temp.Add(item);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in temp)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString(); 
        }
    }
}
