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

int c = x1 - x2;
int d = y1 - y2;
int f = 2;
double respow1 = Math.Pow(c, f);
double respow2 = Math.Pow(d, f);
Console.WriteLine($"{respow1}, {respow2}");
double e = respow1 + respow2;
Console.WriteLine($"{e}");
double resqrt = Math.Sqrt(e);
Console.WriteLine($"{resqrt:f2}");
// double resSqrt = Math.Sqrt(b);
// Console.WriteLine($"{resSqrt:f2}");

// int a = 25;
// int b = 2;
// double resQrt = Math.Sqrt(a);
// Console.WriteLine(resQrt);
// double respPow = Math.Pow(a, b);
// Console.WriteLine(respPow);


