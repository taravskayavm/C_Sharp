// Напишите программу, которая принимает на вход число и проверяет, является ли оно четным (делится ли на два без остатка)
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число => ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num % 2 == 0) {
Console.WriteLine("Число четное");
} else {
Console.WriteLine("Число нечетное");
}