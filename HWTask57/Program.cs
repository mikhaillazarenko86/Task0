// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8
int ReadInt(string message)                                                 // Метод считывает целое число от пользователя.
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetRandomMatrix(int rows, int columns, int leftRange = 1, int rightRange = 9)
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
int[,] newmatrix = new int[rowsCount, columnsCount];


for (int i = 0; i < rowsCount; i++)
{

  for (int j = 0; j < columnsCount; j++)
  {  
  for (int d = j+1; d < columnsCount; d++)
  {
    if (matrix[i,j] > matrix[i,d])
    {
        int temp = matrix[i,j];
        matrix[i,j] = matrix[i,d];
        matrix[i,d] = temp;
    } 
  }
  }
  
  
}

Console.WriteLine();
PrintMatrix(matrix);
