using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    //базовый класс Mammal
    public class Mammal
    {
        //свойства характерные всем млекопитающим
        public string Name { get; set; }
        public int Age {  get; set; }
        public double Weight {  get; set; }

        //конструктор с параметрами 
        public Mammal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        //метод строкового представления 
        public override string ToString()
        {
            return Name + "," + Age + "," + Weight;
        }
    }
}
