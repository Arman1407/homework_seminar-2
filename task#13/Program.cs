﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
n = Math.Abs(n);   // указывает на отрицательные числа, можно ибез неё
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (n > 999)   // т.к. 1000 четырехзначное исло
    {
        n /= 10;      //  цикл до тех пор пока число не станет трехзначным
    }                 //  также можно: n = n / 10, убирает по 1 цифре от числа
Console.WriteLine(n % 10);  // результат, показывает последнюю цифру
}

