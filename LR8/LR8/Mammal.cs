using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    //абстрактный класс 
    public abstract class Mammal
    {
        public string Name { get; set; }
        //с абстрактным свойством 

        public abstract double Speed {  get; set; }

        public Mammal(string name) {
            Name = name;
        }

        //с обстрактным методом 
        public abstract void Voice();

        public override string? ToString()
        {
            return Name + ", " + Speed;
        }
    }
}
