using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1_2
{
    interface IBook
    {
        string this[int index] { get;set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        string IBSN { get; set; }
        int Year { get; set; }
        void Show();
    }
}
