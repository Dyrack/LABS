using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    //класс человек 
    public class Person
    {
        //приватное статическое поле которое отвечает за нумерацию всех айдишников в программе 
        private static int NEXT_ID = 1;
        //поле айди человека (уникальное)
        int id = NEXT_ID++;
        string fio;
        string date;
        int age;

        //конструктор с параметрами 
        public Person(string fIO, string date, int age)
        {
            fio = fIO;
            this.date = date;
            this.age = age;

            //добавление созданного объекта в базу всех людей 
            People.Add(this);
        }

        //свойство для айди (только на чтение)
        public int ID
        {
            get { return id; }
        }

        //свойство для фио 
        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Date
        {
            get { return date; }   
            set { date = value; }   
        }

        //метод строкового представления
        public override string? ToString()
        {
            return this.id + ";" + this.fio + ";" + this.date + ";" + age;
        }
    }
}
