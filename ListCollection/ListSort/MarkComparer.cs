using System;
using System.Collections.Generic;
using System.Text;

namespace ListSort
{
    class MarkComparer : IComparer<Student>
    {
        public int Compare(Student std1, Student std2)
        {
            return std1.Mark.CompareTo(std2.Mark);
        }

    }
}
