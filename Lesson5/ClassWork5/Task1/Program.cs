// Задача 1: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

int[] ChangeArrayElements(int[] arr)
{
    for (int i = 0; i < arr.Lenght; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int[] arr = GenerateArray(12, -9, 9);
ShowArray(arr);
System.Console.WriteLine();
ChangeArrayElements(arr);
ShowArray(arr);
