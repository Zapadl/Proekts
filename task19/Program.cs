// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
void Palindrome(int num1)
{
    while (num1 > -10000 && num1 < 10000 || num1 > 99999 || num1 < -99999)
    {
        Console.Write("Введите пятизначное число: ");
        num1 = Convert.ToInt32(Console.ReadLine());
    }
    int numleft = num1 / 10000;
    int numright = num1 % 10;
    if (numleft == numright)
    {
    numleft = num1 / 1000 % 10;
    numright = num1 % 100 / 10;
    if (numleft == numright) Console.Write($"Число {num1} - палиндром.");
    else Console.Write($"Число {num1} - не палиндром.");
}
else
    Console.Write($"Число {num1} - не палиндром.");
}
Palindrome(num);



