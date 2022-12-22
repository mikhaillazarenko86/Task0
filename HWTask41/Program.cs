// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4
string newstr = "";
for (int i = 0; ;i++)
{
Console.WriteLine($"Введите число {i + 1}, для прекращения ввода введите stop");
string str = Console.ReadLine();
newstr = newstr + str;
if (str == "stop")
{
   break;
}

}
// Console.WriteLine(newstr);
 int[] myArray = new int[newstr.Length-4];
for (int j = 0; j < newstr.Length-4; j++)
{
 myArray[j] = newstr[j] -'0';
 }
// Console.WriteLine($"{string.Join(", ", myArray)}");  
int count = 0;
for (int d = 0;d < myArray.Length; d++)
{
   if (myArray[d] < 0)
   {
      count = count +1;
   }
}
Console.WriteLine($"Количество отрицательных элементов введено: {count}");
