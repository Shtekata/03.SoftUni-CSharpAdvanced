using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex;

            private readonly List<Book> books;

            public Book Current => books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext() => ++currentIndex < books.Count;

            public void Reset() => currentIndex = -1;

            public LibraryIterator(List<Book> books)
            {
                Reset();
                this.books = books;
                books.Sort(new BookComparator());
            }
        }
    }
}
