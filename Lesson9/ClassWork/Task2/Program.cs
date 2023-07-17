﻿// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите натуральное число: ");
int N = ReadInput("Введите натуральное число: ");

void PrintNaturalNumes(int M, int N)
{
    if (M > N) return;
    System.Console.WriteLine(M);
    PrintNaturalNumes(M + 1, N);
}

PrintNaturalNumes(M, N);
