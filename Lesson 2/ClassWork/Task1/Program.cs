// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();

/* 
Функция вводит целое значение из консоли
*/

int ReadInt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());   // Чтение строки и преобразование в число
    return number;                                      // Возврат целого числа
}

bool Validate3sign(int number)
{
    if (number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не 3-хзначное число");
        return false;
    }

    return true;
}

int digit = ReadInt ("Введите 3-хзначное число => ");
if (Validate3sign(digit))
{
    int lastDigit = digit % 10;
    System.Console.WriteLine($"Третья цифра числа {digit} равна {lastDigit} ");
}