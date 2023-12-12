using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    //создание структуры Auto. структура отличается от класса тем что она типа значения а класс типа ссылки 
    public struct Auto
    {
        //поля
        string model;
        int age;
        int probeg;

        //конструктор
        public Auto(string model,int age,int probeg)
        {
            this.model = model;
            this.age = age;
            this.probeg = probeg;
        }

        //конструктор копирования 
        public Auto(Auto auto)
        {
            this.model=auto.model;
            this.age = auto.age;
            this.probeg = auto.probeg;
        }

        //свойство 
        public string Model { 
            get { return this.model; } 
            set { this.model = value; }
        }

        //метод копирования который копирует и заменяет модель на новое значение 
        public Auto copy(string newModel)
        {
            Auto newAuto = this with { model = newModel};
            return newAuto;
        }

        //для печати 
        public override string? ToString()
        {
            return "(" + this.model + ", " + this.age + ", " + this.probeg + ")";
        }
    }
}
