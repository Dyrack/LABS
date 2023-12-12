using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    //статический класс со всеми статическими элементами . используется как база данных всех людей 
    public static class People
    {
        //статическое поле список людей 
        private static List<Person> people = new List<Person>();

        //метод добавления нового человека в список
        public static void Add(Person person)
        {
            people.Add(person);
        }

        //метод поиска человека по его айди
        public static Person Searсh(int id)
        {
            //проходим циклом по списку всех людей и если айди совпадает то возвращаем человека по его айди 
            foreach(Person person in people)
            {
                if(person.ID == id) 
                    return person;
            }
            //если такого человека нет то возвращаем null
            return null;
        }

        //cтатическое свойство для получения всех людей 
        public static List<Person> PEOPLE
        {
            get
            {
                return people;
            }
        }
    }
}
