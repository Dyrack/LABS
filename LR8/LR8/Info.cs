using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR8
{
    public class Info
    {
        public static void Show(Mammal mammal)
        {
            mammal.Voice();
            Console.WriteLine(mammal.Speed);
        }
    }
}
