// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите натуральное число: ");
int N = ReadInput("Введите натуральное число: ");

AkkermanFunction(M, N);

void AkkermanFunction(int M, int N)
{
    Console.Write(Akkerman(M, N));
}

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }

}