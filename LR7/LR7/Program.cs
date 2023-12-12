using LR7;

//создание объектов базового класса 
Mammal mammal1 = new Mammal("Petya", 20, 100);
Mammal mammal2 = new Mammal("Vasya", 20, 100);
Console.WriteLine(  mammal1);
Console.WriteLine(  mammal2);

//создание объектов производных классов 
Cat cat = new Cat("Murzik", 10, 20, 100);
Dog dog = new Dog("Sharik", 20, 50, 1, 150);
Console.WriteLine(cat);
Console.WriteLine(dog);

//вызов методов для производных классов 
cat.TakeMouse();
dog.EatBone();

//создание объекта репозитория 
MammalsRepository mammalsRepository = new MammalsRepository();
//добавление новых объектов 
mammalsRepository.Add(mammal1);
mammalsRepository.Add(mammal2);
mammalsRepository.Add(cat);
mammalsRepository.Add(dog);

//получение массива количеств для каждого типа 
int[] res = mammalsRepository.Counts();
foreach (int i in res)
{
    Console.Write(i + " ");
}