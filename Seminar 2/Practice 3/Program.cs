//Напишите программу, которая 
// будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число: ");
// string a = Console.ReadLine();
// int numbera = Convert.ToInt32(a);

// Console.WriteLine("Введите второе число: ");
// string b = Console.ReadLine();
// int numberb = Convert.ToInt32(b);

// int krat = numbera % numberb;

// if (krat != 0)
// {
//     Console.Write("числа не кратны. Остаток: ");
//     Console.WriteLine(krat);
// }
// else
// {
//     Console.WriteLine("числа кратны!");
// }


//Напишите программу, которая 
// принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int number = Convert.ToInt32(str);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("yes");
}
else 
{
    Console.WriteLine("no");
}