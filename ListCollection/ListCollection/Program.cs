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
            SumAllNumbers sumAll = new SumAllNumbers();
            ArrayList list = sumAll.inputData();
            Console.Write("List after processing: ");
            foreach (int i in sumAll.sum(list))
            {
                Console.Write(i + " ");
            }
        }
    }
}
