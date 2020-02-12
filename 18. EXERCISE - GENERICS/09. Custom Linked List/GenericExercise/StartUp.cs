    
namespace GenericExercise
{
    using System;
   public class Program
    {
       public static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<string>();
            doublyLinkedList.AddLast("string1");
            doublyLinkedList.AddLast("string2");
            doublyLinkedList.AddLast("string3");

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }

            //doublyLinkedList.Print(Console.WriteLine);
            //Console.WriteLine();
            //
            //Console.WriteLine(doublyLinkedList.Count == 2);
            //Console.WriteLine();
            //
            //var print = doublyLinkedList.ToArray();
            //foreach (var item in print)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //
            //var printList = doublyLinkedList.ToList();
            //foreach (var item in printList)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //
            //Console.WriteLine(doublyLinkedList.Contains("string2"));
            //Console.WriteLine();
        }
    }
}
