
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) Console.Write("нет"); //понедельник
else if (day == 2) Console.Write("нет"); //вторник
else if (day == 3) Console.Write("нет"); //среда
else if (day == 4) Console.Write("нет"); //четверг
else if (day == 5) Console.Write("нет"); //пятница
else if (day == 6 || day == 7) Console.Write("да"); //суббота и воскресенье
//else if (day == 6) Console.Write("да"); //суббота
//else if (day == 7) Console.Write("да"); // воскресенье
else Console.Write("Данного дня недели не существует");

