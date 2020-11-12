using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListCollection
{
    class SumAllNumbers
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
        public ArrayList sum(ArrayList list) {
            ArrayList sum = new ArrayList();
            int length = list.Count;
            for (int i = 0; i < length/2; i++) {
                sum.Add((int)list[i] + (int)list[length- i - 1]);
            }
            if ((length / 2) * 2 != length) {
                sum.Add(list[length / 2]);
            }
            return sum;
        }
    }
}
