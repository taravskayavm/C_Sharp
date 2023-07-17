// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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
    Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        res = M + SumMN(M, N);
        return res;
    }
}
PrintNaturalNumes(M, N);