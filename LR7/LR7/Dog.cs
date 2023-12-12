using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    //производный класс собака
    public class Dog : Mammal // наследование от класса млекопитающего 
    {
        //свойства характерные собакам но за счет наследования в этом классе будут свойства и из млекопитающего 
        public int CatCachedCount {  get; set; }
        public int BonesCount {  get; set; }

        //конструктор с параметрами . происходит вызов конструктора базового класса для инициализации свойств базового класса 
        public Dog(string name, int age, double weight, int catCachedCount, int bonesCount) : base(name, age, weight)
        {
            //явные поля инициализируются явно 
            CatCachedCount = catCachedCount;
            BonesCount = bonesCount;
        }

        //метод съест кость 
        public void EatBone()
        {
            Console.WriteLine(  "Bone is eated!");
        }

        //переопределение метода строковго представления 
        public override string ToString()
        {
            //вызов метода из базового класса и добавление свойств из текущего
            return base.ToString() + ", " + CatCachedCount + ", " + BonesCount;
        }
    }
}
