using System;

namespace CustomStructures
{
    /// <summary>
    /// Custom Stack Implementation
    /// </summary>
    public class CustomStack<T>
    {
        /// <summary>
        /// Default size of internal array
        /// </summary>
        private const int defaultSize = 4;

        /// <summary>
        /// Internal array
        /// </summary>
        private T[] innerArr;

        /// <summary>
        /// Number of elements in the stack
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Creates stack with default size of the inner array
        /// </summary>
        public CustomStack()
        {
            innerArr = new T[defaultSize];
        }

        /// <summary>
        /// Adds element to the top of the stack
        /// </summary>
        /// <param name="element">Element to add</param>
        public void Push(T element)
        {
            if (innerArr.Length == Count)
            {
                Grow();
            }

            innerArr[Count] = element;
            Count++;
        }

        /// <summary>
        /// Checks the element on the top of the stack,
        /// without removing it
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            CheckIfEmpty();

            return innerArr[Count - 1];
        }

        /// <summary>
        /// Returns the top element of the stack and removes it
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            CheckIfEmpty();
            Count--;
            T tempElement = innerArr[Count];
            innerArr[Count] = default;

            return tempElement;
        }

        /// <summary>
        /// Iterates through the custom stack
        /// </summary>
        /// <param name="action">Action to execute on each element</param>
        public void ForEach(Action<T> action)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                action(innerArr[i]);
            }
        }

        private void Grow()
        {
            T[] tempArr = new T[innerArr.Length * 2];

            innerArr.CopyTo(tempArr, 0);
            innerArr = tempArr;
        }

        private void CheckIfEmpty()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
    }
}
