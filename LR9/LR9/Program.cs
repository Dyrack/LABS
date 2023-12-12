using LR9;
using System.Net.Mail;
//создание контейнера с имайл сообщениями 
NotificationContainer<EmailNotification> notificationContainer1 = new NotificationContainer<EmailNotification>();
//добавление новых объектов 
notificationContainer1.Add(new EmailNotification("3", "3@mail.ru"));
notificationContainer1.Add(new EmailNotification("1", "1@mail.ru"));
notificationContainer1.Add(new EmailNotification("2", "2@mail.ru"));

//полуение объекта по существуюзему индексу 
Console.WriteLine(notificationContainer1.Get(0));
//получение объекта по несуществуюзему индексу вернут нул 
Console.WriteLine(notificationContainer1.Get(-1));

//проверка на то что объект существует при сравнении задействуется метод equals
Console.WriteLine(notificationContainer1.Contains(new EmailNotification("3", "3@mail.ru")));

//сортировка через компаре ту 
notificationContainer1.Sort();

//вывод после сортировки 
Console.WriteLine(notificationContainer1);

//создание контейнера для смс уведомлений и выполнение тех же действий что укащано на верху 
NotificationContainer<SMSNotification> notificationContainer2 = new NotificationContainer<SMSNotification>();
notificationContainer2.Add(new SMSNotification("3", "+79998100163"));
notificationContainer2.Add(new SMSNotification("1", "79998100164"));
notificationContainer2.Add(new SMSNotification("2", "79998100165"));

Console.WriteLine(notificationContainer2.Get(0));
Console.WriteLine(notificationContainer2.Get(-1));

Console.WriteLine(notificationContainer2.Contains(new SMSNotification("3", "+79998100163")));

notificationContainer2.Sort();
Console.WriteLine(notificationContainer2);


//пример ковариации 
//можем создать интерфейс от базового класса но положить туда объект от производного 
IMessenger<Notification> outlook = new EmailMessenger();
Notification message = outlook.WriteMessage("Hello World", "1@mail.ru");
Console.WriteLine(message.Message);    

//а тут создается объеккт от производного
IMessenger<EmailNotification> emailClient = new EmailMessenger();

//но присваивается на объект базового это возмрдно за счет ковариации 
IMessenger<Notification> messenger = emailClient;
Notification emailMessage = messenger.WriteMessage("Hi!", "2@mail.ru");
Console.WriteLine(emailMessage.Message);    