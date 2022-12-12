// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int[] array = new int[8];
for (int i = 0; i <= 7; i++)
{
Console.WriteLine($"Введите число {i + 1}");
int b = Convert.ToInt32(Console.ReadLine());
array[i] = b;
}
Console.WriteLine(string.Join(", ", array));