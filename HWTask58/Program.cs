// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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


int rowsCount1 = ReadInt("Введите число строк массива 1");
int columnsCount1 = ReadInt("Введите число столбцов массива 1");
int rowsCount2 = ReadInt("Введите число строк массива 2");
int columnsCount2 = ReadInt("Введите число столбцов массива 2");
if (rowsCount1 != rowsCount2 || columnsCount1 != columnsCount2)
{
    Console.WriteLine("Выполнение задачи невозможно");
}
else
{
int[,] matrix1 = GetRandomMatrix(rowsCount1, columnsCount1);
int[,] matrix2 = GetRandomMatrix(rowsCount2, columnsCount2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
int[,] prodArray = new int[rowsCount1,columnsCount1];
int prod = 1;
for (int i = 0; i < rowsCount1; i++)
{
    for (int j = 0; j < columnsCount1; j++)
    {
        prodArray[i,j] = matrix1[i,j] * matrix2[i,j];
    }
}
Console.WriteLine();
PrintMatrix(prodArray);
}
