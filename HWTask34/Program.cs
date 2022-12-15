// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
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
int lenght = 10;
int leftrange = 100;
int rightrange = 999;
int[] massive = Getarray(lenght, leftrange, rightrange);
Console.WriteLine($"{string.Join(", ", massive)}");
int EvenNumber()

{
int sum = 0;
    for (int j = 0; j < massive.Length; j++)
    {
    int b = massive[j] % 2;
        if (b == 0)
        {
        sum = sum + 1;
        }  
    }
return sum;
}

int d = EvenNumber();
Console.WriteLine($"Количество четных чисел в массиве {d}");
