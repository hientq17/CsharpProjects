using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise2
{
    abstract class Animal
    {
        public Animal(string type)
        {
            this.type = type;
        }
        public string type;
        public abstract string Sound();
        public abstract string Infomation();
    }
}
