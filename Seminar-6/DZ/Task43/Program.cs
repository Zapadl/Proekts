// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Метод введения нужных значений вручную с проверкой ввода.
void ValueManualMode(out double b1_c, out double k1_a, out double b2_d, out double k2_b)
{
    Console.WriteLine("Введите необходимые значения для прямых:");
    // y = k1 * x + b1, y = k2 * x + b2
    Console.WriteLine("y = ax + c, y = bx + d");

    Console.Write("Введите k1:");
    while (!double.TryParse(Console.ReadLine(), out k1_a))
    {
        Console.Write("Ошибка ввода. Введите k1:");
    }

    Console.Write("Введите b1:");
    while (!double.TryParse(Console.ReadLine(), out b1_c))
    {
        Console.Write("Ошибка ввода. Введите b1:");
    }

    Console.Write("Введите k2:");
    while (!double.TryParse(Console.ReadLine(), out k2_b))
    {
        Console.Write("Ошибка ввода. Введите k2:");
    }

    Console.Write("Введите b2:");
    while (!double.TryParse(Console.ReadLine(), out b2_d))
    {
        Console.Write("Ошибка ввода. Введите b2:");
    }
}
// Метод рассчёта точек пересечения двух прямых.
void ParallelChecker(double b1_c, double k1_a, double b2_d, double k2_b, double x1, double y1)
{
    Console.WriteLine($"y = {k1_a}x + {b1_c}, y = {k2_b}x + {b2_d}");
    if (k1_a == k2_b && b1_c == b2_d)
    {
        Console.WriteLine("Прямые совпадают, у них бесконечное число точек пересечения.");
    }

    else if (k1_a == k2_b && b1_c != b2_d)
    {
        Console.WriteLine("Прямые не имеют точек пересечения, они параллельны.");
    }

    else
    {
        x1 = (b1_c - b2_d) / (k2_b - k1_a);
        y1 = k2_b * x1 + b2_d;
        Console.WriteLine($"Точка пересечения двух прямых XY({Math.Round(x1, 2)} ; {Math.Round(y1, 2)}).");
    }
}



Console.Clear();

double b1 = default, k1 = default,
       b2 = default, k2 = default,
       x = default, y = default;

ValueManualMode(out b1, out k1, out b2, out k2);
ParallelChecker(b1, k1, b2, k2, x, y);

