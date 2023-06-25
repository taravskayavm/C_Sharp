// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int ReadInt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int digit = ReadInt("Введите число => ");
if (digit > 99)
{
    int thirdDigit = ((digit / 100)) % 10;
    System.Console.WriteLine($"Третья цифра числа {digit} равна {thirdDigit} ");
}
if (digit < 100)
{
    Console.WriteLine("Третьей цифры нет");
}