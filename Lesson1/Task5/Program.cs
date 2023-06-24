// Сделайте вычисление модулей числа

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num;
if (num < 0) {
   res = -num;
}
Console.WriteLine($"Модуль числа равен {res}");
