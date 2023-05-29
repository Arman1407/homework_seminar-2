// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int count = 0, m = n;
while (n >0)
{
    n = n / 10;
    count++;
}

Console.WriteLine($"В числе {m} {count}  цифры");

// if (n > 1000)
// {
//     int b = n / 10;
//     n++;
//     Console.WriteLine(b / 10 % 10);
// }

if (n < 100)
{
        Console.WriteLine("Третьей цифры нет");
}

