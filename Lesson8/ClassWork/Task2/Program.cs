// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


Console.Clear();

int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = 4;
    int cols = 4;
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
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

void ShowAverageValues(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:f1}\t");
    }
}

int[,] ReverseArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] result = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[j, i] = array[i, j];
        }
    }
    return result;
}

int[,] TransparentArr(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i; j < arr.GetLength(1); j++)
        {

            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
    return arr;
}

int[,] array = CreateArr();
ShowArray(array);
System.Console.WriteLine();
int[,] reverse = ReverseArray(array);
ShowArray(reverse);
System.Console.WriteLine();
ShowArray(TransparentArr(array));