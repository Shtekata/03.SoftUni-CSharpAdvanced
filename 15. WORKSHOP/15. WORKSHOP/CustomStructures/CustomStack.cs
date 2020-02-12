using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStructures
{
   public class CustomStack
    {
        /// <summary>
        /// Default size of internal array
        /// </summary>
        private const int defaultSize= 4;

        /// <summary>
        /// Internal array
        /// </summary>
        private int[] innerArr;

        /// <summary>
        /// Number of elements in the stack
        /// </summary>
        public int Count { get; private set; }

        public CustomStack()
        {
            innerArr = new int[defaultSize];
        }
        
        public void Push(int element)
        {
            if (Count == innerArr.Length)
            {
                Grow();
            }
            innerArr[Count] = element;
            Count++;
        }

        public int Peek()
        {
            ChekIfEmpty();
            return innerArr[Count - 1];
        }
        
        public int Pop()
        {
            ChekIfEmpty();
            Count--;
            var temp = innerArr[Count];
            innerArr[Count] = default;
            return temp;
        }

        public void ForEach(Action<int>go)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                go(innerArr[i]);
            }
        }
        private void Grow()
        {
            var temp = new int[innerArr.Length * 2];
            innerArr.CopyTo(temp, 0);
            innerArr = temp;
        }

        private void ChekIfEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

    }
}
