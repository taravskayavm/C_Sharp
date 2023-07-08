// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

Console.Clear();

int[] GenerateArray(int lenght, int start, int end)
{
    int[] array = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(start, end + 1);
    }
    return array;
}

void ShowArray(int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.Write($"{item} ");
    }
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
ShowArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных значений равна {SumPositive(arr)}");
System.Console.WriteLine($"Сумма отрицательных значений равна {SumNegative(arr)}");
System.Console.WriteLine($"Сумма положительных {SumPlus(arr, 1)}, а сумма отрицательных {SumPlus(arr, -1)}");
