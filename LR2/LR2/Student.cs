using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    //cоздание класса описывающего студента 
    public class Student
    {
        //поля класса они описывают студента 
        string fio;
        int age;
        string numberGroup;
        int course;

        //конструктор он заполняет поля класса нужными данными. в скобках записаны параметры(аргументы)
        public Student(string fio, int age, string numberGroup, int course)
        {
            this.fio = fio;
            this.age = age;
            this.numberGroup = numberGroup;
            this.course = course;
        }

        //конструктор копирования. он создает новый объект студента копируя данные из студента-параметра
        public Student(Student student)
        {
            this.fio=student.fio;
            this.age = student.age;
            this.numberGroup = student.numberGroup;
            this.course = student.course;
        }

        //свойство. позволяет прочитать или установить новое значение в поле fio
        public string FIO
        {
            get { return this.fio; }
            set { this.fio = value; }
        }
        
        //метод копирования с заменой поля фио на новое значение. отдает копию но заменяет фио на новое 
        public Student copy(string newFio)
        {
            Student newStudent = new Student(this);
            newStudent.FIO = newFio;
            return newStudent;
        }

        //метод для печати студента . он дает нам текст содержащий данные студента в круглых скобках 
        public override string? ToString()
        {
            return "(" + this.fio + ", " + this.age + ", " + this.numberGroup + ", " + this.course + ")";
        }
    }
}
