Console.Write("Ведите число ");
int number = int.Parse(Console.ReadLine());
int number2 = number * -1;
while (number2 <= number)
{ 
    Console.Write($"{number2}, ");
    number2++;
}
