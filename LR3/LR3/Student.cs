using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    //класс студент
    public class Student
    {
        //поля класса 
        string name;
        string surname;
        int age;
        double avgScore;

        //конструктор с параметрами 
        public Student(string name, string surname, int age, double avgScore)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.avgScore = avgScore;
        }

        //свойства для всех полей 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Avgscore
        {
            get { return avgScore; }
            set { avgScore = value; }
        }

        //преобразование студента в строку 
        public override string? ToString()
        {
            return this.name + ";" + this.surname + ";" + this.age + ";" + this.avgScore;
        }
    }
}
