// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Console.Clear();
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i =1;
// int Count( int num)
// {
// while ( i <=num )
// {
// num = num/10;
// i++;
// }
// return i++;
// }
// int number = Count(num);
// Console.WriteLine(number);

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int NumbersL(int n1)
// {
// int i;
// for (i = 0; n1>0; i++)
// {
// n1 = n1 / 10;
// }
// return i;
// }
// int result = NumbersL(n);
// Console.Write(result);

//через цикл
int CountDigits(int num)
{
if (num != 0)
{
if (num < 0) num = -num;
int count = default;
while (num > 0)
{
num = num / 10;
count++;
}
return count;
}
return 1;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(number);
Console.WriteLine(result);
