// // // Напишите программу, 
// которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// string str = Console.ReadLine();
// int number = Convert.ToInt32(str);

// if (number >= 100 && number <= 999)
// {
//     int a = (number / 10) % 10;
//     Console.WriteLine("Вторая цифра: " + a);
// }
// else
// {
//     Console.WriteLine("Повторите попытку,число не трехзначно!");
// }



// Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (number >= 1000)
    {
        number = number /10;
    }
    int a = number % 10;
    Console.WriteLine("Третья цифра: " + a);

}

