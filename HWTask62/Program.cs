// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:


int[,] GetRandomMatrix(int rows, int columns, int leftRange = 1, int rightRange = 9)
{
    int[,] matr = new int[rows, columns];

    var rand = new Random();
    for(int j = 0; j < matr.GetLength(1); j++)
    {
        int i = 0;
        matr[i, j] = rand.Next(leftRange, rightRange + 1);
    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int j =  matr.GetLength(1)-1;
        matr[i, j] = rand.Next(leftRange, rightRange + 1);
    }
    for (int j = matr.GetLength(0)-2 ; j > 0; j--)
    {
        int i =  matr.GetLength(0)-1;
        matr[i, j] = rand.Next(leftRange, rightRange + 1);
    }
    for (int i = matr.GetLength(0)-1; i >= 1; i--)
    {
        int j =  0;
        matr[i, j] = rand.Next(leftRange, rightRange + 1);
    }
      for (int j = 1; j < matr.GetLength(0)-1; j++)
    {
        int i = 1;
        matr[i, j] = rand.Next(leftRange, rightRange + 1);
    }
     for (int j = 2; j >= 1; j--)
    {
        int i = 2;
        matr[i, j] = rand.Next(leftRange, rightRange + 1);
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




int[,] matrix = GetRandomMatrix(4, 4);
PrintMatrix(matrix);
