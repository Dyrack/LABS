using LR2;

//создание объекта а 
Student a = new Student("Petrov P.P", 20, "A-213", 3);

//читаем фио студента а 
Console.WriteLine(a.FIO);

//присваиванием студенту а новое значение фио 
a.FIO = "Ivanov I.A";

//выводим студента а 
Console.WriteLine(a);

Student b = new Student("Cvetov O.D", 19, "B-312", 2);

Console.WriteLine(b.FIO);

//делаем копию студента а через конструктор копирования . с это копия а 
Student c = new Student(a);
Console.WriteLine( c);

//делаем копию из а но заменяем фио на новое 
Student d = a.copy("Sidorov T.K");
Console.WriteLine(d);

//создание переменной структуры
Auto auto1 = new Auto("BMW", 10, 100000);
Console.WriteLine(auto1);

Auto auto2 = new Auto(auto1);
Console.WriteLine(auto2);

Auto auto3 = auto1.copy("Mers");
Console.WriteLine(auto3);

