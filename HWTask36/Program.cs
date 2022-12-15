// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
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
int sum = 0;
for (int i = 1; i < massive.Length; i++)
{
   if (i % 2 == 0)
  {
    Console.WriteLine($"четная позиция {massive[i]}");
  }
  else
  {
    Console.WriteLine($"нечетная позиция {massive[i]}");
    sum = sum + massive[i];
  }
}
Console.WriteLine($"сумма элементов на нечетных позициях {sum}");

// for (int j = 0; j < length / 2; j++)
// {
//     int[] newarray = new int(length / 2) ;
//     newarray[j] = massive[i + 2];
//     Console.WriteLine($"{string.Join(", ", newarray)}");
// }