using System;
using System.Collections.Generic;

namespace WORKSHOP
{
    class DoublyLinkedList
    {
        private class LinkNode
        {
            public LinkNode(object value)
            {
                Value = value;
            }
            public object Value { get; }
            public LinkNode PreviousNode { get; set; }
            public LinkNode NextNode { get; set; }
        }

        private LinkNode head;
        private LinkNode tail;
        public int Count { get; private set; }

        public void AddFirst(object number)
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

        public void AddLast(object number)
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

        public object RemoveFirst()
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

        public object RemoveLast()
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
        public void Print(Action<object> action)
        {
            var currentNode = head;
            while (currentNode!=null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public bool Contains(object value)
        {
            var temp = head;

            while (temp!=null)
            {
                if (temp.Value == value)
                {
                    return true;
                }
                temp = temp.NextNode;
            }

            return false;
        }

        public object[] ToArray()
        {
            var arr = new object[Count];
            var temp = head;

            var count = 0;

            while (temp!=null)
            {
                arr[count++] = temp.Value;
                temp = temp.NextNode;
            }

            return arr;
        }

        public List<object> ToList()
        {
            var list = new List<object>(Count);
            var temp = head;

            while (temp!=null)
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
    }
}
