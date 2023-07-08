// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumberInArr(int[] arr, int number)
{
    foreach (int item in arr)
    {
        if (item == number)
        {
            return true;
        }
    }
    return false;
}

int[] arr = GenerateArray(12, -9, 9);
ShowArray(arr);
System.Console.WriteLine();

int number = ReadInt("Задайте число");

System.Console.WriteLine(FindNumberInArr(arr, number));
