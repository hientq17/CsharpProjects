using System;

namespace Excersise2
{
    class Dog : Animal
    {
        private string Name { get; set; }
        private string Breed { get; set; }

        public Dog(string type,string name,string breed) : base(type)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public override string Infomation()
        {
            return "Dog: \n     " +
                "- Name = " + Name +"\n     " +
                "- Breed = "+Breed+"\n     " +
                "- Type = " + type + "\n     " +
                "- Sound = " + Sound() + "\n";
        }

        public override string Sound()
        {
            return "GAUGAUGAU";
        }
    }
}
