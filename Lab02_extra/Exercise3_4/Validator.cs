using System;

namespace Exercise3_4
{
    class Validator
    {
        public static int InputIntNumber(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + " : ");
                    return int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input an integer. Try again!");
                }
            }
        }
        public static int InputIntNumberRange(string s, int a, int b)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + " : ");
                    int temp = int.Parse(Console.ReadLine());
                    if (temp < a || temp > b)
                    {
                        Console.WriteLine($"Input out of range {a} - {b}");
                        throw new Exception("Out of range");
                    }
                    return temp;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Please input in range {a} - {b}");
                }
            }
        }
        public static double InputDoubleNumber(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + " : ");
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please input a double. Try again!");
                }
            }
        }
        public static string InputString(string s, string regrex)
        {
            while (true)
            {
                try
                {
                    Console.Write(s + " : ");
                    string temp = Console.ReadLine();
                    //Check regrex
                    return temp;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Bad input at " + s + ", try again!");
                }
            }
        }
    }
}
