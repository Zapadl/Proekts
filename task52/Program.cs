// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // [двухмерный массив запятой] название метода(строка, столбец, значение 1, значение 2)
{
    int[,] matrix = new int[rows, columns]; //0, 1, двухмерный массив из строк и столбцов

    Random rnd = new Random(); // заполнение массива
    for (int i = 0; i < matrix.GetLength(0); i++) // цикл который проходит по строкам , и смещается по ним
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //цикл который проходит по столбцам,  и смещается по ним
        {
            matrix[i, j] = rnd.Next(min, max + 1); //заполнение двумерного массива по строке I и столбцам J

        }
    }
    return matrix; //возврат результата
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} || "); // цифра пять это форматирование вывода, наведение красоты
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void AverageColums(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++) // цикл который проходит по столбцам , и смещается по ним
    {
        int srAr=0;
        for (int j = 0; j < matrix.GetLength(0); j++) //цикл который проходит по строкам,  и смещается по ним
        {
            srAr += matrix[j, i];
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/matrix.GetLength(0)}");
    }
}

Console.Clear();
int[,] arr = CreateMatrixRndInt(7, 9, 1, 100);
PrintMatrix(arr);
AverageColums(arr);

