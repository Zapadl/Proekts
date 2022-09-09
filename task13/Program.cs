// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число не менее трехзначного");
int num = Convert.ToInt32(Console.ReadLine());
int num2 =(int)num;
if (num<100)
{
    Console.WriteLine("третьей цифры нет");   
}
else {
while (num2 > 999 || num2 < -999)
{
    num2 =num2/10;
}
int num3 = num2 % 10;
Console.WriteLine($"третья цифра от {num} имеет значение {num3}");
}