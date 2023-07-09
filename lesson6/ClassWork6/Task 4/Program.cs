//Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] GenerateArray(int length, int start = 1, int end = 99)
{
    int[] array = new int[length];
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

int[] CopyArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

int[] array = GenerateArray(5); // Ссылка на область памяти
int[] array2 = CopyArray(array);
ShowArray(array);
System.Console.WriteLine();
array[0] = 100;

ShowArray(array);
System.Console.WriteLine();
ShowArray(array2);