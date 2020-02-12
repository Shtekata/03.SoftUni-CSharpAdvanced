using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsExercises
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> item;
        private int index;
        public ListyIterator(List<T> item)
        {
            this.item = item;
            index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index < item.Count - 1)
            {
                return true;
            }

            return false;
        }

        public T Print()
        {
            if (item.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return item[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in item)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
