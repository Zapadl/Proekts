// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }
}

int[] IntArrayManualMode(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}е число: ");
        while (!int.TryParse(Console.ReadLine(), out array[i]))
        {
            Console.Write($"Ошибка ввода. \nВведите {i + 1}е число: ");
        }
    }
    return array;
}

int AboveZero(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}



Console.Clear();

int arraySize = default;
int result = default;

Console.Write("Сколько чисел будем вводить? ");
while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize < 0)
{
    Console.Write("Ошибка ввода. \nСколько чисел будем вводить? ");
}

int[] newArray = IntArrayManualMode(arraySize);
PrintArray(newArray);
result = AboveZero(newArray);
Console.Write($" -> {result} совпадений с числами больше ноля.");


