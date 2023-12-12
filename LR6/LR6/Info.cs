using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR6
{
    public class Info
    {
        //метод который печатает на экран информацию о переданном объекте 
        public static void Print(A a)
        {
            Console.WriteLine(a.Name);
            Console.WriteLine(a.Age);
            Console.WriteLine(a.Weight);
            //если те данные которые могут быть нул равны нул то выводим нет данных.
            //тут используем классический иф. ниже будет показано как можно это сократить 
            if (a.Patronimyc == null)
            {
                Console.WriteLine("Patronimyc No Data");
            }
            else
            {
                Console.WriteLine(a.Patronimyc);
            }

            if (a.Level == null)
            {
                Console.WriteLine("Level No data");
            }
            else
            {
                Console.WriteLine(a.Level);
            }

            if (a.Salary == null)
            {
                Console.WriteLine("Salary No data");
            }
            else
            {
                Console.WriteLine(a.Salary);
            }
            Console.WriteLine(  );
        }

        //метод который присваивает значение 120 в свойство в случае если оно нул 
        public static void Set(A a)
        {
            a.Salary ??= 120;
        }

        //метод который может принимать на вход объект или нул возвращает значение
        //поля Age если объект а не нул и свойство Age не нул иначе вернет 0
        public static int GetLevel(A? a)
        {
            return a?.Age ?? 0;
        }

        //метод который приниает на вход объект и возвращает значение свойства Salary или 5 если оно нул .
        //сам переданный в метод объект нулом быть не может 
        public static double GetSalary(A a)
        {
            return a.Salary ?? 5.0;
        }
    }
}
