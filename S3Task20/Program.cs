// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координату X точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());
// int a = 2;
int c = x1 - x2;
int d = y1 - y2;
int f = 2;
double respow1 = Math.Pow(c, f);
double respow2 = Math.Pow(d, f);
int g = respow1;
int e = respow2;
int b = g + e;
double resSqrt = Math.Sqrt(b);
Console.WriteLine($"{resSqrt:f2}");