// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Vvedite chislo 1");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Vvedite chislo 2");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (b < a) Console.WriteLine("Error");
else
{
int Line(int a, int b)
{
if (a == b) return b; 
int temp = Line(a+1,b);
int sum = a + temp;
return sum;
}
Console.Write(Line(a, b));
}