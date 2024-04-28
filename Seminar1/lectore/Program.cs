//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
//на само себя).

//Например:
//4 -> 16
//-3 -> 9
//-7 -> 49

// prinyat chislo
// poschitat kvadrat (chislo na chislo)
// vivesti chislo

//123 - "123"
// int - string
//Console.ReadLine => string
// string => int
//Convert.ToInt32(string) => int

Console.WriteLine ("Введите число");
string input = Console.ReadLine();
int number = Convert.ToInt32 (input);
int result = number * number;
Console.WriteLine (result);