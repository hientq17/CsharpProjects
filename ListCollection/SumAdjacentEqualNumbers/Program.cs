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
            SumAdjacentEqualNumber sumAdjacent = new SumAdjacentEqualNumber();
            ArrayList list = sumAdjacent.inputData();
            list = sumAdjacent.processing(list);
            Console.Write("List after processing: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
