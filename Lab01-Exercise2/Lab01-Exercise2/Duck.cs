using System;

namespace Excersise2
{
    class Duck : Animal
    {
        private string Name { get; set; }
        public Duck(string type,string name) : base(type)
        {
            this.Name = name;
        }
        public string Swim(string SwimObject)
        {
            return SwimObject;
        }
        public override string Infomation()
        {
            return "Duck:\n     " +
                "- Name = " + Name + "\n     " +
                "- Type = " + type + "\n     " +
                "- Sound = " + Sound() + "\n";
        }

        public override string Sound()
        {
            return "CAPCAPCAP";
        }
    }
}
