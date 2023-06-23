// Напишите программу, которая на вход принимает число и выдает его квадрат
// (число, умноженое на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();                                // Очистка экрана
Console.WriteLine("Введите число => ");         // Вывод приглашения для пользователя
string inputedValue = Console.ReadLine();     // Ввод пользователя (строки)
int number = Convert.ToInt32(inputedValue);     // Преобразует строку в целое число
Console.WriteLine("Вы ввели число " + number);
Console.WriteLine($"Вы ввели число {number}");

int square = number * number;                   // Вычисление квадрата
Console.WriteLine($"Квадрат числа {number} равен {square}"); // Вывод результата
