// Напишите программу, которая на вход принимает два числа и выдает, какое большее, какое меньшее
// a = 5; b = 7 -> max = 7, min = 5
// a = -9; b = -3 -> max = -3, min = -9

Console.Clear();
Console.WriteLine("Введите первое число => ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите второе число => ");
string number2 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);

if (num1 > num2) {
Console.WriteLine($"max = {num1}, min = {num2}");
} else {
Console.WriteLine($"max = {num2}, min = {num1}");
}