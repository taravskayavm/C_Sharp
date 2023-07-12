// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
//выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]

// Введенный элемент 6, результат: такого элемента нет.

Console.Clear();

int[,] CreateArr(int rows, int columns)
{
    int[,] arrayD2 = new int[rows, columns];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = i + j;
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

(int, int) FindElement(int[,] arr, int number)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number) return (i, j);
        }
    }
    return (-1, -1);
}

int rows = ReadInt("Введите число строк ");
int columns = ReadInt("Введите число столбцов ");
int[,] array = CreateArr(rows, columns);
ShowArray(array);
int num = ReadInt("Введите элемент для поиска");
System.Console.WriteLine();
(int r, int c) = FindElement(array, num);
if (r == -1)
{
    System.Console.WriteLine($"Введенный элемент {num} не найден");
}
else
{
    System.Console.WriteLine($"Введенный элемент {num}, результат: {FindElement(array, num)}");
}
