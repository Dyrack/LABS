using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class A
    {
        //свойство не допускающее значение нул
        public string Name {  get; set; }
        //свойство не допускающее значение нул
        public int Age { get; set; }
        //свойство не допускающее значение нул
        public double Weight { get; set; }

        //свойство допускающее значение нул
        public string? Patronimyc { get; set; }

        //свойство допускающее значение нул
        public int? Level { get; set; }

        //свойство допускающее значение нул
        public double? Salary { get; set; }


    }
}
