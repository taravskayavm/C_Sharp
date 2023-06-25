// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Clear();
Console.WriteLine("Введите день недели: ");
string day = Console.ReadLine();
int dayNumber = Convert.ToInt32(day);
if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Число должно быть в интервале от 1 до 7");
}
else
{
    string[] weeks = { "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday" };
    Console.WriteLine(weeks[dayNumber - 1]);
}

if (dayNumber <= 5)
{
    Console.WriteLine("Это будний день");
}
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Это выходной");
}