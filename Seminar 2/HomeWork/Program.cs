// // // Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);

if (number >= 100 && number <= 999)
{
    int a = (number / 10) % 10;
    Console.WriteLine("Вторая цифра: " + a);
}
else
{
    Console.WriteLine("Повторите попытку,число не трехзначно!");
}