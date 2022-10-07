Console.Clear();
Console.WriteLine();

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    int i = 0;
    while (i < array.Length)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
        i += 1;
    }
    return Math.Round((max - min), 1);
}
double[] arr = CreateArrayRndDouble(5, 1, 100);
PrintArray(arr);
double result = Difference(arr);
Console.WriteLine();
Console.WriteLine($"{result}");