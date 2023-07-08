// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();

int[] ToBinary(int number)
{
    int[] arr = new int[8];
    int i = arr.Length - 1;
    while (number > 0)
    {
        arr[i] = number % 2;
        number /= 2;
        i--;
    }
    return arr;
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
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInd))
    {
        return convertedInd;
    }

    System.Console.WriteLine("Вы не ввели число");
    Environment.Exit(0);
    return 0;
}

int number = ReadInt("Введите число ");
int[] array = ToBinary(number);
ShowArray(array);