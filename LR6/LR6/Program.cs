using LR6;

//создание объекта класса А
A a = new A();
//заполнение свойств без нул
a.Name = "Petr";
a.Age = 20;
a.Weight = 70;
a.Patronimyc = "Palych";
a.Level = 1;
a.Salary = 1000;
Info.Print(a);

//создание объекта класса А
A b = new A();
b.Name = "Petr";
b.Age = 20;
b.Weight = 70;
b.Patronimyc = null; // патронимик допускает значение нул 
b.Level = 1;
b.Salary = 1000;
Info.Print(b);

A c = new A();
c.Name = "Petr";
c.Age = 20;
c.Weight = 70;
c.Patronimyc = null; //допускает значение нул
c.Level = null; //допускает значение нул 
c.Salary = null; //допускает значение нул 
Info.Print(c);

A d = new A();
d.Name = null; //тут свойство не допускает значение нул но так как это объект то мы можем насильно туда записать нул на свой страх и риск 
d.Age = 20; //а вот со значимыми типами так не получится . если значимый тип не допускает нул то туда мы не сможем записать нул никак вообще 
d.Weight = 70;
d.Patronimyc = null;
d.Level = null;
d.Salary = null;
Info.Print(d);

try
{
    int length = d.Name.Length; //вот например тут так как мы насильно закинули в свойство нул
                                //котрое не должно быть нул и пытаемся к нему обратиться.
                                //получим исключение которое пришлось обработать чтобы программа не упала 
    Console.WriteLine(length);
}
catch (NullReferenceException e)
{
    Console.WriteLine("Name Could be null");
}

Info.Set(d);
Info.Print(d);
Console.WriteLine(Info.GetLevel(null));
d.Salary = null;
Console.WriteLine(Info.GetSalary(d));