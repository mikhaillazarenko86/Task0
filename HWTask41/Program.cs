// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4
string newstr = "";
for (int i = 0; ;i++)
{
Console.WriteLine($"Введите число {i + 1}, для прекращения ввода введите stop");
string str = Console.ReadLine();
newstr = newstr + "," + str;
if (str == "stop")
{
   break;
}

}
newstr = newstr[..^4];
Console.WriteLine(newstr);
int number = int.Parse(newstr);
Console.WriteLine(number);
int[] myArray = new int[newstr.Length];
for (int d = 0; d < newstr.Length; d++)
{
if (newstr[d]== ',')
myArray[d] = int.Parse(newstr[d-1]);
}
Console.WriteLine($"{string.Join(", ", myArray)}");
