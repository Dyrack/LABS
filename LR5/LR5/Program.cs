using DataAccess;
using LR3;
using LR5;

University university = new University();
university.Add(new Student("Ivan Ivanov", "15.12.1999", 20, 4.85));
university.Add(new Student("Petr Petrov", "13.09.2020", 3, 4.85));
university.Add(new Student("Gena Bukin", "13.09.2021", 2, 4.85));
Console.WriteLine(university);

bool resRemove = university.Remove(0);
Console.WriteLine(resRemove);

Console.WriteLine(university);

bool resRemove1 = university.Remove(-1);
Console.WriteLine(  resRemove1);

Student st = university.Search(0);
Console.WriteLine(st);

StudentsRepository studentsRepository1 = new StudentsRepository(university);
studentsRepository1.Save("st1.csv");

StudentsRepository studentsRepository2 = new StudentsRepository("st1.csv");
University fromFile = studentsRepository2.University;
Console.WriteLine("University from file");
Console.WriteLine(fromFile);

Person person1 = new Person("Ivanov I.A", "12.11.1998", 20);
Console.WriteLine(  person1);


Person person2 = new Person("Petrov I.A", "12.11.1998", 20);
Console.WriteLine(person2);

Console.WriteLine("People-----");
List<Person> lst = People.PEOPLE;
foreach (Person person in lst)
{
    Console.WriteLine(person);
}