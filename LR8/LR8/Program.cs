
using LR8;

//создание обхектов всех классов  и вызов переопределнных методов 
Cat cat = new Cat("Vasya", 10);
Console.WriteLine(cat);
cat.Voice();

Dog dog = new Dog("Sharik", 20);
Console.WriteLine(dog);
dog.Voice();

Rat krysa = new Rat("Marusya", 1000);
Console.WriteLine(krysa);
krysa.Voice();

Console.WriteLine();
Info.Show(cat);
Info.Show(dog);
Info.Show(krysa);