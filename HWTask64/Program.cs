﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
int minnum = 2;
int maxnum = 4;
int Line (int m, int n)
{
if(n < 0) return n;

if(n == m) return n;


Console.Write(Line(m+1, n));
return m;

}
Console.Write(Line(minnum,maxnum));