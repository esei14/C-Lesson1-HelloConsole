// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число");
string? input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
Console.WriteLine("Введите второе число");
string? input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);

    if (number1 / number2 == number2)
    {
        Console.WriteLine("первое число вляется квадратом второго");
    }
    else
    {
        Console.WriteLine("первое число не вляется квадратом второго");
    }
