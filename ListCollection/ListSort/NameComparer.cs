using System;
using System.Collections.Generic;
using System.Text;

namespace ListSort
{
    class NameComparer:IComparer<Student>
    {
        public int Compare(Student std1, Student std2)
        {
            return std1.Name.CompareTo(std2.Name);
        }
    }
}
