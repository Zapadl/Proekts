// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();

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

void SearchElem(int[,] matrix, int str, int col)
{
    if (matrix.GetLength(0) >= str && matrix.GetLength(1) >= col)
    {
        Console.WriteLine($"Есть совпадение с координатами -> Число {matrix[str - 1, col - 1]}.");
    }
    else
    {
        Console.WriteLine($"Совпадений с координатами  не нашлось.");
    }
}



int[,] arr = CreateMatrixRndInt(3, 4, 1, 100);
PrintMatrix(arr);
Console.Write("Введите строку: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int col = Convert.ToInt32(Console.ReadLine());
SearchElem(arr, str, col);
