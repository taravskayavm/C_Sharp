// Напишите программу,которая принимает на вход координаты точки (X и Y),
// причем X не равен 0 или Y не равен 0 и выдает номер четверти плоскости,
// в которой находится эта точка.

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return int.Parse(Console.ReadLine());
}

int CalculateQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    {
        return 4;
    }
}

bool ValidateCoords(int x1, int y1)
{
    if (x1 == 0 || y1 == 0)
    {
        System.Console.WriteLine("Одна из координат равно 0");
    } return false;
}

int x = Prompt("Введение X");
int y = Prompt("Введите Y");

if (ValidateCoords(x, y))
{
    int quarter = CalculateQuarter(x, y);
    System.Console.WriteLine($"Четверть номер {quarter}");
}