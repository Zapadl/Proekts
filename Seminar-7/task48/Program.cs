// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5






int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // [двухмерный массив запятой] название метода(строка, столбец, значение 1, значение 2)
{
    int[,] matrix = new int[rows, columns]; //0, 1, двухмерный массив из строк и столбцов

    Random rnd = new Random(); // заполнение массива
    for (int i = 0; i < matrix.GetLength(0); i++) // цикл который проходит по строкам , и смещается по ним
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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

int[,] array2D = CreateMatrixRndInt(3, 4, -999, 99);
PrintMatrix(array2D);