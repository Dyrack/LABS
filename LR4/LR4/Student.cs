using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    //класс студент 
    public class Student
    {
        //автосвойство которое работает на гет и на сет (короткая запись )
        public string FIO {  get; set; }
        
        //поле класса 
        int age;

        //свойство которое работает с полем класса age . работает на гет на возврат
        //и на сет на установку данных в поле в случае если подаваемое значение положительное 
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value> 0)
                {
                    this.age = value;
                }
            }
        }

        //вычисляемое свойство которое возаращает bool
        //cчитаем что студент молодой вслучае если его возраст более 25 лет :)
        public bool IsYong
        {
            get
            {
                //если возраст больше 25 то вернуть тру иначе фолс 
                return this.Age > 25;
            }
        }

        //метод который в виде строки возвращает значение всех свойств 
        public string GetInfo()
        {
            return this.FIO + ", " + this.Age + ", " + this.IsYong;
        }

        //метод который в виде строки возвращает значение всех свойств включая целые если параметр includeIntProperty тру 
        public string GetInfo(bool includeIntProperty)
        {
            if(includeIntProperty == true)
            {
                return this.GetInfo();
            }
            else
            {
                return this.FIO + ", " + this.IsYong;
            }
        }

        //метод которой возвращает строкове представление объекта
        public override string? ToString()
        {
            return "(" + this.FIO + ", " + this.age + ")";
        }
    }
}
