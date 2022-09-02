// Напишите программу , которая принимает на вход трехзначное 
// число и на выходе показывает последнию цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 1000 && num1 > 99)
{
    num1 = num1 % 10;
    Console.WriteLine(num1);
}
else
{
    Console.Write("Ошибка, введите трехзначное число");
}
