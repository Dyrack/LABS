using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    //класс кошки наследуется от базового класса млекопитающего 
    public class Cat : Mammal
    {
        public int MouseExperience { get; set; }

        //конструктор со всеми параметрами и вызов конструктора базового класса 
        public Cat(string name, int age, double weight, int mouseExperience) : base(name, age, weight)
        {
            MouseExperience = mouseExperience;
        }

        //метод поймать мышь 
        public void TakeMouse()
        {
            Console.WriteLine("Mouse is catched!");
        }

        //gереопределение метода строкового представления 
        public override string? ToString()
        {
            //вызов метода из базового класса и добавление свойств из текущего
            return base.ToString() + ", " + this.MouseExperience;
        }
    }
}
