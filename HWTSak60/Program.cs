// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] myArray = new int[2, 2, 2];
int b = 11;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int d = 0; d < myArray.GetLength(2); d++)
        {
            myArray[i,j,d] = b++;
        }
    }
}
for (int i = 0; i < myArray.GetLength(0); i++)
{
    Console.WriteLine($"Индекс уровня {i}");
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int d = 0; d < myArray.GetLength(2); d++)
        {
           Console.Write($"{myArray[i,j,d]} ({i}, {j}, {d})");
        }
       Console.WriteLine();
    }
    
    
}