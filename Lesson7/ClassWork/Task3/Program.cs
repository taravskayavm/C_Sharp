// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// (Число строк должно быть равно числу столбцов).
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

int[,] CreateArr()
{
    Random rnd = new Random();
    int rows = rnd.Next(2, 5);
    int cols = rnd.Next(2, 5);
    int[,] array = new int[rows, cols];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; i < array.GetLength(1); i++)
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
        for (int j = 0; i < array.GetLength(1); i++)
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

double[] CalcAverageArrRows(int[,] arr)
{
    double[] averageValuesArray = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        averageValuesArray[i] = (double)sum / arr.GetLength(1);
    }
    return averageValuesArray;
}

int[,] array = CreateArr();
ShowArray(array);
System.Console.WriteLine();
int[,] reverse = ReverseArray(array);
double[] averageValues = CalcAverageArrRows(reverse);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
ShowAverageValues(averageValues);