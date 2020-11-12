using System;
using System.Collections.Generic;

namespace Exercise1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager manager = new BookManager();
            manager.InitData();
            manager.GUI();
        }
   
    }
}
