using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise
{
   public class Box<T>
    {
        public List<T> privateCollection;

        public Box()
        {
            privateCollection = new List<T>();
        }

        public void Add(T item)
        {
            privateCollection.Add(item);
        }

        public void Swap(int x, int y)
        {
            var temp = privateCollection[x];
            privateCollection[x] = privateCollection[y];
            privateCollection[y] = temp;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in privateCollection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
