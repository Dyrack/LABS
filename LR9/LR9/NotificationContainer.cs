using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR9
{
    //создание класса контейнера(шаблоннй класс) 
    public class NotificationContainer<T> where T : Notification //говорим что у шаблонного типа есть ограничение что он должен быть Notification которй реализует интерфейс IComparable  
    {
        //список объектов 
        List<T> list = new List<T>();

        //метод добавления нового объекта в список 
        public void Add(T item)
        {
            this.list.Add(item);
        }

        //метод получения объекта по индексу 
        public T? Get(int index)
        {
            if(index < 0 || index >= list.Count)
            {
                return default(T);
            }

            return list[index];
        }

        //метод проверки есть ли такой объект в списке (задействуует Equals для объектов)
        public bool Contains(T value)
        {
            return this.list.Contains(value);
        }

        //сортировка без компаратора через метод компаре ту 
        public void Sort()
        {
            this.list.Sort();
        }

        //строкое представление
        public override string ToString()
        {
            return string.Join("; ", this.list);
        }
    }
}
