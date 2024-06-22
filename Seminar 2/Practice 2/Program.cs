//Напишите программу, 
//которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа.

//456 -> 46
//782 -> 72
//918 -> 98

// Random generate = new Random();
// int number = generate.Next(100, 1000);

// int a = number / 100;
// int b = number % 10;

// Console.Write(a);
// Console.Write(b);

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");
string a = Console.ReadLine();
int numbera = Convert.ToInt32(a);

Console.WriteLine("Введите второе число: ");
string b = Console.ReadLine();
int numberb = Convert.ToInt32(b);

if (numbera == numberb * numberb || numberb == numbera * numbera)
{
    Console.WriteLine("числа являются квадртаом друг друга");
}
else
{
    Console.WriteLine("числа не являются квадртаом друг друга ");
}



