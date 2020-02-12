﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book //: IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = authors;
        }

        //public int CompareTo(Book other)
        //{
        //    var result = Year.CompareTo(other.Year);
        //
        //    if (result == 0)
        //    {
        //        result = Title.CompareTo(other.Title);
        //    }
        //
        //    return result;
        //}

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
