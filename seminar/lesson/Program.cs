// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

// 1 Prinyat chislo
// 2 poschitat kvadrat
// 3 vivesti chislo

// int - string
// 123 - "123"
// int
// Console.ReadLine => string
// string => int
// Convert.ToInt32(striing) => int

Console.WriteLine("Введите число");
string? input = Console.ReadLine();
int number = Convert.ToInt32(input);
int result = number * number;
Console.WriteLine(result);