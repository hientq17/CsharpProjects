using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListCollection
{
    class Program
    {
        static void Main()
        {
            MergeList merger= new MergeList();
            ArrayList list1 = merger.inputData();
            ArrayList list2 = merger.inputData();
            ArrayList list = merger.merge(list1, list2);
            Console.Write("List after processing: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
