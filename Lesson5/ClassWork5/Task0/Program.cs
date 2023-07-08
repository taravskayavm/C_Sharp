// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

Console.Clear();

int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + "\t");
    }
    System.Console.WriteLine();
}

int SumPositive(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumNegative(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item < 0)
        {
            sum += item;
        }
    }
    return sum;
}

int SumPlus(int[] array, int sign)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item * sign > 0)
        {
            sum += item;
        }
    }
    return sum;
}

int[] arr = GenerateArray(12, -9, 9);
PrintArray(arr);
System.Console.WriteLine($"Сумма положительных значений равна {SumPositive(arr)}");
System.Console.WriteLine($"Сумма отрицательных значений равна {SumNegative(arr)}");
System.Console.WriteLine($"Сумма положительных {SumPlus(arr, 1)}, а сумма отрицательных {SumPlus(arr, -1)}");
