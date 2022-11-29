Console.Clear();
Console.WriteLine("Ведите первое числ ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе числ ");
int number2 = int.Parse(Console.ReadLine());
if(number1/number2 == number2)
{
Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
Console.WriteLine("Первое число  не является квадратом второго числа");
}

