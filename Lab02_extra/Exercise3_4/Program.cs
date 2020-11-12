using System;

namespace Exercise3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountManager manager = new AccountManager();
            manager.InitData();
            manager.GUI();
        }
    }
}
