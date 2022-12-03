// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);

int digit3 = number % 10;
int digit1 = number / 100;
int digit2 = number / 10 % 10;

Console.WriteLine($"Случайное число = {number}, первая цифра = {digit1}, вторая цифра = {digit2}, третья цифра = {digit3}");

int rez = digit1 * 10 + digit3;
Console.WriteLine("Итоговое число: " + rez);