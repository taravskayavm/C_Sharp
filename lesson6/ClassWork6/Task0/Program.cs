// Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.Clear();

// Метод, принимающие данные на вход:

int ReadInt(string message)    // Чтение с консоли целого значения
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine()); // Пользователь вводит размер массива
}   

// Метод создания массива:

int[] CreateArray(int len, int min, int max) // Генерируем массив: длина, минимальный элемент и максимальный
{
    int[] array = new int [len];        
    Random rnd = new Random();      // Генератор случайных чисел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
}

// Метод демонстрации массива на экране:
void PrintArray (int[] array) // Вывод массива
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

// Собственно задание
int [] ReverseArray(int[] array) // Возращаем массив, который получаем на вход
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        Swap(array, i, array.Length - 1 -i);
    }
    return array;
}

void Swap(int[] array, int i1, int i2)  // Функция, которая заменяет в массива два элемента
{
    int temp = array[i1];       // Временная переменная
    array[i1] = array[i2];
    array[i2] = temp;
}

int len = ReadInt("Введите длину массива: ");
int[] arr = CreateArray(len, 0, 10);
PrintArray(arr);
PrintArray(ReverseArray(arr));
