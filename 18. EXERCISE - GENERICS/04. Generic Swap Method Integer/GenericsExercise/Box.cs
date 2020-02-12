using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExercise
{
   public class Box<T>
    {
        public List<T> myCollection;

        public Box()
        {
            myCollection = new List<T>();
        }

        public void Add(T item)
        {
            myCollection.Add(item);
        }

        public void Swap(int x, int y)
        {
            var temp = myCollection[x];
            myCollection[x] = myCollection[y];
            myCollection[y] = temp;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in myCollection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
