// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int number = new Random().Next(1, 10000000);
int number = new Random().Next(1, 1000);
Console.WriteLine(number);
 
    while (number >= 1000)
    {
     number = number / 10;    
    }
Console.WriteLine(number);

if (number < 100)
{
  Console.WriteLine("Нет третьей цифры");  
}
else
{
int digit3 = number % 10;
Console.WriteLine(digit3);
}


