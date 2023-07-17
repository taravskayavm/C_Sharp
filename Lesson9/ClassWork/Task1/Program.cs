// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadInput("Введите натуральное число: ");

// Рекурсию пишем только через функцию
void PrintNaturalNumes(int N)
{
    if (N == 0) return;
    PrintNaturalNumes(N - 1);
    System.Console.WriteLine(N);
}

PrintNaturalNumes(N);