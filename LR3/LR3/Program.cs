using DataAccess;
using LR3;

University university = new University();
university.Add(new Student("Ivan", "Ivanov", 20, 4.85));
university.Add(new Student("Petr", "Petrov", 20, 4.85));
university.Add(new Student("Gena", "Bukin", 20, 4.85));
Console.WriteLine(university);

bool resRemove = university.Remove(0);
Console.WriteLine(resRemove);

Console.WriteLine(university);

bool resRemove1 = university.Remove(-1);
Console.WriteLine(  resRemove1);

Student st = university.Search(0);
Console.WriteLine(st);

StudentsRepository studentsRepository1 = new StudentsRepository(university);
studentsRepository1.Save("st.csv");

StudentsRepository studentsRepository2 = new StudentsRepository("st.csv");
University fromFile = studentsRepository2.University;
Console.WriteLine( "University from file");
Console.WriteLine(fromFile);
