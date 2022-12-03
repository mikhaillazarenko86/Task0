// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int rez = number % 2;
if (rez == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}