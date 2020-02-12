using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            //var library = new Library(
            //    new Book("A", 1756, "B", "C", "D"),
            //    new Book("R", 1856, "T", "Y", "U"),
            //    new Book("Z", 1956, "X", "C", "V"),
            //    new Book("K", 2056, "L", "M", "N"));

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);


            foreach (var item in libraryTwo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
