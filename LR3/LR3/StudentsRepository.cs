using LR3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace DataAccess. namespace нужен чтобы группировать классы по смысловым частям программы.
//все классы которые как-то связаны по смыслу необходимо добавлять в один namespace
namespace DataAccess
{
    //класс репозитория(хранилища) студентов 
    public class StudentsRepository
    {
        //в полях класса университет 
        University university;

        //конструктор принимает на вход имя файла и загружает универститет из файла 
        public StudentsRepository(string fileName)
        {
            this.university = new University();
            //открывает поток связанный с файлом 
            using(StreamReader streamReader = new StreamReader(fileName))
            {
                //цикл пока не конец файла 
                while(!streamReader.EndOfStream)
                {
                    //считываем строку из файла 
                    string line = streamReader.ReadLine();
                    //разбиваем строку по точке с запятой 
                    string[] mass = line.Split(";");
                    //создаем объект студента подавая из массива нужные данные имя на 0 месте фамилия на 1 и тд 
                    Student student = new Student(mass[0], mass[1], int.Parse(mass[2]), double.Parse(mass[3]));
                    //добавляем студента в университет 
                    this.university.Add(student);
                }
            }
        }

        //конструктор который принимает на вход университет и проставляет его в поле класса 
        public StudentsRepository(University university)
        {
            this.university = university;
        }

        //свойства на гет и сет 
        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        //метод сохранения университета который находится в поле класса в файл 
        public void Save(string fileName)
        {
            //открывается поток на вывод в файл 
            using(StreamWriter streamWriter = new StreamWriter(fileName))
            {
                //циклом проходим по университету
                for(int i = 0; i < this.university.Count; i++)
                {
                    //берем каждого студента по индексу 
                    Student student = this.university.Search(i);
                    //выводим каждого студента в поток(в файл)
                    streamWriter.Write(student.ToString() + "\n");
                }
            }
        }
    }
}
