using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ListCollection
{
    class SumAdjacentEqualNumber
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

        public ArrayList processing(ArrayList list) {
            int check = IsAdjacentEqual(list);
            while (check != int.MaxValue)
            {
                list[check] = (int)list[check] + (int)list[check + 1];
                list.RemoveAt(check + 1);
                check = IsAdjacentEqual(list);
            };
            return list;
        }

        public int IsAdjacentEqual(ArrayList list) {
            for (int i = 0; i < list.Count-1; i++) {
                if ((int)list[i] == (int)list[i + 1])
                {
                    return i;
                }
            }
            return int.MaxValue;
        }
        
    }
}
