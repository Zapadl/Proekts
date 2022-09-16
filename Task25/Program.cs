// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double MyPow(double a, int b)
{
    double x = 1;
    int count = 1;
    while (count <= b)
    {
        x = x * a;
        count++;
    }
    return  x;
}
double x = MyPow(num1, num2);
Console.WriteLine($"{num1} в степени {num2} имеет значение  {x}");