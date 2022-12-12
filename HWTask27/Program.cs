// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("введите число А");
int a = Convert.ToInt32(Console.ReadLine());
int d = a;
string str = Convert.ToString(a);
int lenght = str.Length;
// Console.WriteLine(lenght);
int[] array = new int[lenght + lenght];
for (int i = 0; i < lenght + lenght; i++)
{
int b = a % 10;
if (b == 0)
{
    a = a / 10;
}
else
{
a = a - b;
}
array[i] = b;
// Console.WriteLine(string.Join(", ", array));
}
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
Console.WriteLine($"Сумма чисел в числе {d} равна {sum}");