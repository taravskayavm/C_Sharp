﻿// Напишите программу, которая принимает на вход число и выдает, является ли оно четным (делится ли на два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите первое число => ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе число => ");
string number2 = Console.ReadLine();
Console.WriteLine("Введите третье число => ");
string number3 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
int num3 = Convert.ToInt32(number3);
int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);