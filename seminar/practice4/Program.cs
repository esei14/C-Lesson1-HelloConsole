// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8


Console.WriteLine("Введите трёхзначное число");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
int i = Convert.ToInt32(input);
{
if (number < 100)
{
Console.WriteLine("Не трёхзначное число");
}
else if (number > 999)
{
Console.WriteLine("Не трёхзначное число");
}
else
{
do
{
i = i-10;

}while (i>=10);
Console.Write(i);
}

}
