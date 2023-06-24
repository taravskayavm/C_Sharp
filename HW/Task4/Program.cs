// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num;
int start = 1;
    while (start < num){
        Console.WriteLine(start+1);
        start += 2;
    }