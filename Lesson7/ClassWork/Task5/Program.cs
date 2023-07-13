// Задача 5: Задайте двумерный массив. 
// Найдите максимальный элемент массива и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25

Console.Clear();

int[,] CreateArr(int rows, int columns)
{
    int[,] arrayD2 = new int[rows, columns];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(0, 5);
        }
    }
    return arrayD2;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int FindMax(int[,] arr)
{
    int max = arr[0, 0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > max) max = arr[i, j];
        }
    }
    return max;
}

// int FindMax(int[,] arr)
// {
//     int max = arr[0, 0];
//     foreach (int item in arr)
//     {
//         if (item > max) max = item;
//     }
//     return max;
// }

double GetAverageArr(int[,] arr)
{
    int sum = 0;
    foreach (int item in arr)
    {
        sum += item;
    }
    System.Console.WriteLine(sum);
    System.Console.WriteLine(arr.Length);
    return ((double)sum) / arr.Length;
}

int rows = ReadInt("Введите число строк ");
int columns = ReadInt("Введите число столбцов ");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальный элемент массива {FindMax(array)}");
System.Console.WriteLine($"Среднее арифметическое {GetAverageArr(array):f2}");