// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int M = ReadInput("Введите натуральное число: ");

int PrintNaturalNumes(int M)
{
    if (M == 0) return 0;
    return M % 10 + PrintNaturalNumes(M / 10);
}

System.Console.WriteLine(PrintNaturalNumes(M));

