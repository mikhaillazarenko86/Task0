// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
int[] Getarray(int length, int leftrange, int rightrange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftrange, rightrange + 1);
    }
return array;
}
int length = 11;
int leftrange = 1;
int rightrange = 20;
int[] massive = Getarray(length, leftrange, rightrange);
Console.WriteLine($"{string.Join(", ", massive)}");
int max = massive[0];
int min = massive[0];
for (int i = 1; i < massive.Length; i++)
{
   if (massive[i] > max)
  {
   max = massive[i];

  }
  else
  {
    min = massive[i];
  }
}
int diff = max - min;
Console.WriteLine($" Максимальный элемент массива {max}, минимальный элемент массива {min}, их разница будет равна {diff}");