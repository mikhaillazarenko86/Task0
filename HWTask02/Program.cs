﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
Console.WriteLine("введите число 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
    Console.WriteLine($"min = {number2}");
}
else
{
    Console.WriteLine($"max = {number2}");
    Console.WriteLine($"min = {number1}");
}