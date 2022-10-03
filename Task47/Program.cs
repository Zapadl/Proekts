// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max) // [двухмерный массив запятой] название метода(строка, столбец, значение 1, значение 2)
{
    double[,] matrix = new double[rows, columns]; //0, 1, двухмерный массив из строк и столбцов

    Random rnd = new Random(); // заполнение массива
    for (int i = 0; i < matrix.GetLength(0); i++) // цикл который проходит по строкам , и смещается по ним
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //цикл который проходит по столбцам,  и смещается по ним
        {
            matrix[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble(); //заполнение двумерного массива по строке I и столбцам J
            matrix[i, j] = Math.Round(matrix[i,j],2);
        }
    }
    return matrix; //возврат результата
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6} || "); // цифра пять это форматирование вывода, наведение красоты
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}


double[,] arr = CreateMatrixRndDouble(8, 9, 1, 100);
PrintMatrixDouble(arr);
