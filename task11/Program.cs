// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int MaxDigit(int num)
{
    int firstDigit = num / 100 * 10; //7 от числа 78
    int secondDigit = num % 10; //8  от числа 78
    return firstDigit + secondDigit;
}
int maxDigit = MaxDigit(number);
Console.WriteLine($"{number} -> {maxDigit}");