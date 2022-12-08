// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.WriteLine("Введите пятизначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int a = number1 / 10000;
if (a > 0 & a < 10)
{
int b = 1; 
int j = 10;
int e = 1;
int d = 10000;
int number2 = number1 % 10 * 10000;
int c = number2;
int g = 10;
for (int i = 10; i <= 100000; i = i * 10, j = j * 10, e = e * 10, d = d / 10, number2 = number1 % i % j / e * d, c = c + number2, g = g * 10)
// Console.WriteLine($"{c}");
// Console.WriteLine($"{g}");
if (g == 100000)
{
    if (c == number1)
    {
        Console.WriteLine("Палином");
    }
    else
    {
         Console.WriteLine("Не палином");
    }
}
}
else
{
Console.WriteLine("Неверное число");
}

