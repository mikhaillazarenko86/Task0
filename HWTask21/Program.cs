// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координату X точки 1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки 2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки 2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки 2");
int z2 = Convert.ToInt32(Console.ReadLine());

int c = x1 - x2;
int d = y1 - y2;
int a = z1 - z2;
int f = 2;
double respow1 = Math.Pow(c, f);
double respow2 = Math.Pow(d, f);
double respow3 = Math.Pow(a, f);
// Console.WriteLine($"{respow1}, {respow2}, {respow3}");
double e = respow1 + respow2 + respow3;
// Console.WriteLine($"{e}");
double resqrt = Math.Sqrt(e);
Console.WriteLine($"Расстояние между точками {resqrt:f2}");