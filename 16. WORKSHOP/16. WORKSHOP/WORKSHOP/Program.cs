using System;

namespace WORKSHOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddLast("string1");
            doublyLinkedList.AddLast("string2");
            doublyLinkedList.AddLast("string3");
            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(3);
            doublyLinkedList.AddLast(5);

            

            //doublyLinkedList.Print(Console.WriteLine);
            //Console.WriteLine(doublyLinkedList.Count == 2);
            //
            //var print = doublyLinkedList.ToArray();
            //
            //foreach (var item in print)
            //{
            //    Console.WriteLine(item);
            //}
            //
            //var printList = doublyLinkedList.ToList();
            //
            //foreach (var item in printList)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(doublyLinkedList.Contains("string2"));
            Console.WriteLine(doublyLinkedList.Contains(10));
        }
    }
}
