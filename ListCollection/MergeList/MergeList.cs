using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListCollection
{
    class MergeList
    {
        public ArrayList inputData()
        {
            Console.Write("Input list of numbers (separated by comma): ");
            string[] s = Console.ReadLine().Split(";");
            ArrayList list = new ArrayList();
            foreach (string i in s)
            {
                list.Add(int.Parse(i));
            }
            return list;
        }
        public ArrayList merge(ArrayList list1, ArrayList list2) {
            ArrayList list = new ArrayList();
            int length1 = list1.Count;
            int length2 = list2.Count;
            int i = 0, j = 0;
            while (i < length1 && j < length2) {
                if (length1 > length2) {
                    list.Add(list1[i]);
                    list.Add(list2[j]);
                }
                else
                {
                    list.Add(list2[j]);
                    list.Add(list1[i]);
                }
                  
                i++; j++;
            }
            while (i < length1) {
                list.Add(list1[i]);
                i++;
            }
            while (j < length2)
            {
                list.Add(list2[j]);
                j++;
            }
            return list;
        }
    }
}
