// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

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


void SquareElemMatrix(int[,] matrix) // [двухмерный массив запятой] название метода(строка, столбец, значение 1, значение 2)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
  }

//Решение с меньшим количеством итераций
// int[,] ChangeMatrixRndInt(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i += 2)
// {
// for (int j = 0; j < array.GetLength(1); j += 2)
// {
// array[i, j] *= array[i, j];
// }
// }
// return array;
// }


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
SquareElemMatrix(array2D);
PrintMatrix(array2D);
Console.WriteLine();