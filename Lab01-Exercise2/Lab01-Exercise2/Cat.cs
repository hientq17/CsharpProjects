using System;

namespace Excersise2
{
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string type,string name):base(type)
        {
            this.Name = name;
        }

        public string Climb(string ClimbObject)
        {
            return ClimbObject;
        }

        public override string Infomation()
        {
            return "Cat:\n     " +
                "- Name = "+Name+"\n     " +
                "- Type = "+type+"\n     " +
                "- Sound = "+Sound()+"\n  ";
        }

        public override string Sound()
        {
            return "MEOMEOMEO";
        }
    }
}
