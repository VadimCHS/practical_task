// Задача 2. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

// Создание двухмерного массива и заполнение случайными числами в заданном диапозоне.
int[,] GetArray(int sizeX, int sizeY, int valueMin, int valueMax)
{
    int[,] array = new int[sizeX, sizeY];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax + 1);
        }
    }
    return array;
}

// среднее арифметическое элементов в каждом столбце.
double[] MeanArithmetic (int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[j, i];
        }
        result[i] = Math.Round(result[i]/array.GetLength(0), 2);
    }
    return result;
}

// Вывод двухмерного массива в консоль.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}


int[,] testArray = GetArray(7, 7, 0, 10);           // Создание массива
PrintArray(testArray);                              // Вывод массива в консоль
Console.Write ($"[{String.Join(", ", MeanArithmetic(testArray))}]"); // Вычисление среднеарифмитического и вывод в консоль