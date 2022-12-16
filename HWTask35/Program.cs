﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] Getarray(int lenght, int leftrange, int rightrange)
{
    int[] array = new int[lenght];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftrange, rightrange + 1);
    }
return array;
}
int lenght = 123;
int leftrange = 0;
int rightrange = 150;
int[] massive = Getarray(lenght, leftrange, rightrange);
// Console.WriteLine($"{string.Join(", ", massive)}");
int count = 1;
for (int i = 0; i < massive.Length; i++)
{
   if (massive[i] >= 10 && massive[i] <= 99)
  {
  count = count + 1;

  }
}
Console.WriteLine($" Количество элементов массива на отрезке от 10 до 99 равно {count}");