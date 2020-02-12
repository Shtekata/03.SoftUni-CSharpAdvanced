using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericExercise
{
    public class DoublyLinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private class LinkNode
        {
            public LinkNode(T value)
            {
                Value = value;
            }
            public T Value { get; }
            public LinkNode PreviousNode { get; set; }
            public LinkNode NextNode { get; set; }
        }

        private LinkNode head;
        private LinkNode tail;
        public int Count { get; private set; }

        public void AddFirst(T number)
        {
            var newHead = new LinkNode(number);

            if (Count == 0)
            {
                tail = head = newHead;
            }
            else
            {
                newHead.NextNode = head;
                head.PreviousNode = newHead;
                head = newHead;
            }

            Count++;
        }

        public void AddLast(T number)
        {
            var newTail = new LinkNode(number);

            if (Count == 0)
            {
                tail = head = newTail;
            }
            else
            {
                newTail.PreviousNode = tail;
                tail.NextNode = newTail;
                tail = newTail;
            }

            Count++;
        }

        public T RemoveFirst()
        {
            CheckIfEmptyThrowExeption();

            var removedNumber = head.Value;

            head = head.NextNode;

            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.PreviousNode = null;
            }

            Count--;

            return removedNumber;

        }

        public T RemoveLast()
        {
            CheckIfEmptyThrowExeption();

            var removedNumber = tail.Value;

            tail = tail.PreviousNode;

            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.NextNode = null;
            }

            Count--;

            return removedNumber;
        }
        public void Print(Action<T> action)
        {
            var currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public bool Contains(T value)
        {
            var temp = head;

            while (temp != null)
            {
                if (temp.Value.CompareTo(value) == 0)
                {
                    return true;
                }
                temp = temp.NextNode;
            }

            return false;
        }

        public T[] ToArray()
        {
            var arr = new T[Count];
            var temp = head;

            var count = 0;

            while (temp != null)
            {
                arr[count++] = temp.Value;
                temp = temp.NextNode;
            }

            return arr;
        }

        public List<T> ToList()
        {
            var list = new List<T>(Count);
            var temp = head;

            while (temp != null)
            {
                list.Add(temp.Value);
                temp = temp.NextNode;
            }

            return list;
        }

        private void CheckIfEmptyThrowExeption()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException
                    ("DoblyLinkedList is empty!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = head;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
