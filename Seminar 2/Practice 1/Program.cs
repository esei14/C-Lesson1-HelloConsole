// Напишите программу, 
// которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Random generateNumber = new Random();
int number = generateNumber.Next(10,100);
Console.WriteLine(number);

int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.WriteLine("первая цифра > второй цифры");
}
else if (b > a)
{
    Console.WriteLine("Вторая цифра > первой цифры");
}
else 
{
    Console.WriteLine("цифры равны");
}