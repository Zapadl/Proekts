// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3-> среда 
// 5-> пятница


Console.Clear();
Console.Write("Введите число от 1 до 7: ");
string day = Console.ReadLine();
if (day == "1") Console.Write("понедельник");
else if (day == "2") Console.Write("вторник");
else if (day == "3") Console.Write("среда");
else if (day == "4") Console.Write("четверг");
else if (day == "5") Console.Write("пятница");
else if (day == "6") Console.Write("суббота");
else if (day == "7") Console.Write("воскресенье");
else Console.Write("Данного дня недели не существует");

