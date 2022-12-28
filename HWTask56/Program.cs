// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int ReadInt(string message)                                                 // Метод считывает целое число от пользователя.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = -1, int rightRange = 2)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
    }
}


int rowsCount = ReadInt("Введите число строк");
int columnsCount = ReadInt("Введите число столбцов");
int[,] matrix = GetRandomMatrix(rowsCount, columnsCount);
PrintMatrix(matrix);
int sum = 0;
int[] array = new int[rowsCount];
for (int i = 0; i < rowsCount; i++)
{

  for (int j = 0; j < columnsCount; j++)
  {  
  sum = sum + matrix[i,j];
  }
  array[i] = sum;
//   Console.WriteLine();
//   Console.WriteLine(sum);
//   Console.WriteLine($"{string.Join(", ", array)}");
  sum = 0;
}
// Console.WriteLine();
// Console.WriteLine($"{string.Join(", ", array)}");
int min = array[0];
int rowsnumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
        rowsnumber++;
    }
}
Console.WriteLine();
Console.WriteLine($"Минимальная сумма равна {min}, на строке c индексом {rowsnumber}");