using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    //класс университет 
    public class University
    {
        //в поле класса список студентов которые есть в университете 
        List<Student> students = new List<Student>();

        //метод добавления нового студента в список студентов 
        //принимается на вход студент как параметр метода 
        public void Add(Student student)
        {
            //добавление осуществляется через стандартный метод Add у списка 
            this.students.Add(student);
        }

        //метод удаления студента по индексу 
        public bool Remove(int index)
        {
            //если индекс некорректный то возвращается неправда 
            if (index < 0 || index >= this.students.Count)
            {
                return false;
            }
            else
            {
                //если индекс корректный то удаляется студент из списка через стандартный метод удаления
                this.students.RemoveAt(index);
                return true;
            }
        }

        //метод поиска студента по ндексу 
        public Student Search(int index)
        {
            //если индекс некорректный то возвращается null(специальное ключевое слово в языке си шарп)
            if (index < 0 || index >= this.students.Count)
            {
                return null;
            }
            else
            {
                //иначе возвращается студент который находится в позиции index
                return this.students[index];
            }
        }

        //свойство которое возвращает количество студентов в университете
        public int Count
        {
            get { return this.students.Count; }
        }

        //метод который возвращает строковое представление университета
        //все студенты будут идти с новой строки. возвращается все в виде одной длинной строки 
        public override string? ToString()
        {
            string res = "";
            foreach (Student student in this.students)
            {
                res += student.ToString() + "\n";          
            }
            return res;
        }
    }
}
