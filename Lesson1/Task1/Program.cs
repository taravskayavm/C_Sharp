// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли второе число квадратом первого:

// a = 5; b = 25 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> нет
// a = -3 b = 9 -> да

Console.Clear();
Console.WriteLine("Введите первое число => ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе число => ");
string number2 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
int square = num1 * num1;
if (square == num2) {
Console.WriteLine("Второе число является квадратом первого");
} else {
Console.WriteLine("Второе число не является квадратом второго");
}