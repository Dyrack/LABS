using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    //при наследовании от этого класса мы должны определить все его абстрактные свойства 
    public class Cat : Mammal
    {
        int MouseExperience { get; set; }

        public Cat(string name, int mouseExperience) : base(name)
        {
            MouseExperience = mouseExperience;
        }

        //переопределнеи абстрактного свойства 
        public override double Speed
        {
            get
            {
                return 20;
            }
            set
            {
                Speed = value;
            }
        }

        //переопределнеи абстарктного класса 

        public override void Voice()
        {
            Console.WriteLine( "myau" ); 
        }

        public override string? ToString()
        {
            return base.ToString() + ", " + MouseExperience;
        }
    }
}
