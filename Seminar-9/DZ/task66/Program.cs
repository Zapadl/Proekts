//  Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите число М: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {numM}; N = {numN} -> ");

int SumNaturalNumbers(int numberM, int numberN)
{
    int sum = numberN;
    if (numberM != numberN)
    {
        sum += SumNaturalNumbers(numberM, numberN - 1);
    }
    return sum;
}
int result = SumNaturalNumbers(numM, numN);
Console.WriteLine(result);