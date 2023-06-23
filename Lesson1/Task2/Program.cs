// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Clear();
Console.WriteLine("Введите день недели: ");
string day = Console.ReadLine();
int dayNumber = Convert.ToInt32(day);
if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Число должно быть в интервале от 1 до 7");
} else {

string [] weeks = {"Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine (weeks[dayNumber-1]);
}


