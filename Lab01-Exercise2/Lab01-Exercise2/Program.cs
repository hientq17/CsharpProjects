using System;

namespace Excersise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog("Mamals","Spike","Bulldog");
            Animal b = new Duck("Bird","Donald");
            Animal c = new Cat("Mamals","Tom");
            Console.WriteLine(a.Infomation());
            Console.WriteLine(b.Infomation());
            Console.WriteLine(c.Infomation());
            Console.WriteLine("Cat can climb "+((Cat)c).Climb("tree"));
            Console.WriteLine("Duck can swim " + ((Duck)b).Swim("pond"));
        }
    }
}
