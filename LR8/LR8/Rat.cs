using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    public class Rat : Mammal
    {

        public double HZ{ get; set; }

        public Rat(string name, double hZ) : base(name)
        {
            HZ = hZ;
        }

        public override double Speed { 
            get { return 40; }
            set { Speed = value; }
        }

        public override void Voice()
        {
            Console.WriteLine(  "iii");
        }

        public override string? ToString()
        {
            return base.ToString() + ", " + Speed;
        }
    }
}
