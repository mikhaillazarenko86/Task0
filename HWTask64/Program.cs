// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int num = 0;
int Line (int n)
{
// if(n == 1) return 5;
if(n == 7) return 8;
Console.Write(Line(n+1));
return n+1;
}
Console.Write(Line(num));