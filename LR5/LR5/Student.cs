using LR5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    //класс студент
    //происходит наследование от класса человек . то есть наследуются
    //все свойства и признаки класса человек
    public class Student : Person 
    {
        //поля класса 
        
        double avgScore;

        //номер зачетки
        int number;

        //конструктор с параметрами 
        public Student(string fIO, string date, int age, double avgScore) : base(fIO, date, age) //тут происходит вызов консруктора базового класса 
        {
            this.avgScore = avgScore;
        }

        //свойства 
        public double Avgscore
        {
            get { return avgScore; }
            set { avgScore = value; }
        }

        public int Number
        {
            set { number = value; }
            get { return number; }
        }

        //преобразование студента в строку 
        public override string? ToString()
        {
            return base.ToString() + ";" + this.number + ";" + this.avgScore;
        }
    }
}
