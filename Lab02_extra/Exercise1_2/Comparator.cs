using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercise1_2
{
    class SortByAuthor : Comparer<Book>
    {
        public override int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }
    class SortByTitle: Comparer<Book>
    {
        public override int Compare([AllowNull] Book x, [AllowNull] Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

}
