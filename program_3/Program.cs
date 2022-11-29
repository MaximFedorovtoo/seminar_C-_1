Console.Write("Введите число ");
int setNumber = int.Parse(Console.ReadLine());

string [] days = {"Понедельник", "Вторник", "Среда","Четверг","Патница","Суббота", "Воскресенье"};

string setDay = days[setNumber-1];

Console.WriteLine($"Вы выбрали - {setDay}");
