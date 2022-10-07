// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],2} ");
            else Console.Write($"{matr[i, j],2}");
        }
        Console.WriteLine("|");
    }
}

void SortMatrix(int[,] matr)
{
    int lines = matr.GetLength(0),
        columns = matr.GetLength(1),
        max = matr[0, 0],
        temp = matr[0, 0];
    for (int count = 0; count < columns; count++)
    {
        for (int i = 0; i != lines; i++)
        {
            for (int j = 0; j != columns - 1; j++)
            {
                if (matr[i, j] < matr[i, columns - 1])
                {
                    temp = matr[i, j];
                    max = matr[i, columns - 1];
                    matr[i, j] = max;
                    matr[i, columns - 1] = temp;
                }

                if (matr[i, j] < matr[i, j + 1])
                {
                    temp = matr[i, j];
                    max = matr[i, j + 1];
                    matr[i, j] = max;
                    matr[i, j + 1] = temp;
                }

            }
        }
    }
}


int[,] matrix = CreateMatrix(9, 7, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);
PrintMatrix(matrix);