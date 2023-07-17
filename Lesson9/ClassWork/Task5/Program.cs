// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInput("Enter A:");

bool Fn(int A)
{
    if (A == 2) return true;
    return A % 2 == 0 && Fn(A / 2);
}

System.Console.WriteLine(Fn(A));
