// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер координатной четверти");
int corr = Convert.ToInt32(Console.ReadLine());

if (corr == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
if (corr == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
if (corr == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
if (corr == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}