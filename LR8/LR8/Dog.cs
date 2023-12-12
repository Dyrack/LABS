using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    public class Dog : Mammal
    {
        public int BonesCount { get; set; }

        public Dog(string name, int bonesCount) : base(name)
        {
            BonesCount = bonesCount;
        }

        public override double Speed {
            get
            {
                return 30;
            }
            set
            {
                Speed = value;
            }
        }
        

        public override void Voice()
        {
            Console.WriteLine("Gav");
        }

        public override string? ToString()
        {
            return base.ToString() + ", " + BonesCount;
        }
    }
}
