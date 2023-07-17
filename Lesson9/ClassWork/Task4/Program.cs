// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

int ReadInput(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInput("Enter A:");
int B = ReadInput("Enter B:");

int Fn(int A, int B)
{
    if (B == 0) return 1;
    return A * Fn(A, B - 1);
}

System.Console.WriteLine(Fn(A, B));