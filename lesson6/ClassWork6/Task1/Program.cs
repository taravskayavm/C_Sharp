// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон

Console.Clear();

int ReadInt(string message)
{
    System.Console.WriteLine($"Введите длину стороны треугольника: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

bool CheckTriangle(int[] arr)
{
    if (arr[0] + arr[1] > arr[2] && arr[1] + arr[2] > arr[0] && arr[0] + arr[2] > arr[1])
        return true;
    return false;
}

int[] sides = new int[3];
for (int i = 0; i < sides.Length; i++)
{
    sides[i] = ReadInt($"Введите {i + 1} сторону ");
}

if (CheckTriangle(sides))
{
    System.Console.WriteLine("Треугольник существует");
}
else
{
    System.Console.WriteLine("Треугольник не существует");
}