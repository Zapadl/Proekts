// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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

//метод который проходит по двумерному массиву и выводит его в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, "); // цифра пять это форматирование вывода, наведение красоты
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}


int SumMidlMatrix(int[,] matrix) // [двухмерный массив запятой] название метода(строка, столбец, значение 1, значение 2)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) result += matrix[i, j];
        }
    }
    return result;
}
// решение  с меньшим количеством кода
// int DiagonalSumMatrix(int[,] matrix)
// {
// int diagnalSumMatrix = default;
// int oversize = 0;
// if (matrix.GetLength(0) > matrix.GetLength(1)) oversize = 1;
// for (int i = 0; i < matrix.GetLength(oversize); i++)
// {

// diagnalSumMatrix += matrix[i, i];

// }
// return diagnalSumMatrix;
// }

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
int sumResult = SumMidlMatrix(array2D);
Console.WriteLine($"сумма элементов находящихся на главной диагонали {sumResult}");