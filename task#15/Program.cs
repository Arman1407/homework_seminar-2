// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 7)
{
Console.Write("Вы ошиблиись!\nВведите номер дня недели: ");
n = int.Parse(Console.ReadLine()!);
}
if (n == 1)
Console.WriteLine("Понедельник - рабочий день");
else if (n == 2)
Console.WriteLine("Вторник - рабочий день");
else if (n == 3)
Console.WriteLine("Среда - рабочий день");
else if (n == 4)
Console.WriteLine("Четверг - рабочий день");
else if (n == 5)
Console.WriteLine("Пятница - рабочий день");
else if (n == 6)
Console.WriteLine("Суббота - выходной");
else
Console.WriteLine("Воскресенье - выходной");








