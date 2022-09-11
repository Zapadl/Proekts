// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double ABDDistance(int xc1, int yc1,int zc1, int xc2, int yc2, int zc2 )
{
    double d = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) +(zc2 - zc1) * (zc2 - zc1) ;
    return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
}
Console.WriteLine($"Расстояние между точками = {ABDDistance(x1, y1, z1, x2, y2, z2)}");