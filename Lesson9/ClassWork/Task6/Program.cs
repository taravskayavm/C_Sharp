// Задача 6: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInput("Enter A: ");

bool Fn(int A, int del = 0)
{
    if (del == 0) del = A - 1;
    if (del == 1) return true;
    return A % del != 0 && Fn(A, del - 1);
}

System.Console.WriteLine(Fn(A));
