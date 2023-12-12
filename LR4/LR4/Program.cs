using LR4;

//создание объекта студента
Student student = new Student();
//запись в фио значения петров пп 
student.FIO = "Petrov P.P";

//попытка записать в возраст значение -1 не получится так как внутри свойства стоит проверка 
student.Age = -1;

//вывод студента на экран . тут вызовется автоматически тустринг 
Console.WriteLine(  student);

//запись в возраст значения 20
student.Age = 20;

//вывод на экран студента 
Console.WriteLine(  student);

//определение молодой ли у нас студент через вычисляемое свойство 
bool isYong1 = student.IsYong;
Console.WriteLine(isYong1);

//изменение возраста на 30
student.Age = 30;

Console.WriteLine(  student);

//определение молодой ли у нас студент через вычисляемое свойство 
bool isYong = student.IsYong;
Console.WriteLine(isYong);

//вызов метода GetInfo() который показывает значение всех свойств 
string res1 = student.GetInfo();
Console.WriteLine(  res1);

//вызов метода GetInfo() который показывает значение всех свойств
//за исключением целочисленных так как я передал в качестве параметра false
string res2 = student.GetInfo(false);
Console.WriteLine(  res2);
