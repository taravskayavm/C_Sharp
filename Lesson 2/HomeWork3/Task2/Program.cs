// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату х для точки 1: ");
int y1 = ReadInt("Введите координату y для точки 1: ");
int z1 = ReadInt("Введите координату z для точки 1: ");
int x2 = ReadInt("Введите координату х для точки 2: ");
int y2 = ReadInt("Введите координату y для точки 2: ");
int z2 = ReadInt("Введите координату z для точки 2: ");

int a = x2 - x1;
int b = y2 - y1;
int c = z2 - z1;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine("Расстояние между точками = " + length);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
