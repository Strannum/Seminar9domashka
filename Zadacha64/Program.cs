﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

void PrintNumbers(int start)
{
    if (start < 1) return; // пошел нахер введи больше 0
    Console.Write($"{start} ");
    if (start == 1) return;
    PrintNumbers(start - 1);
}

PrintNumbers(N);