// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5  7       -2      -0,2
// 1    -3,3    8       -9,9
// 8    7,8     -7,1    9

Console.Clear();

// Создание двухмерного массива и заполнение случайными числами в заданном диапозоне.
double[,] GetArray(int sizeX, int sizeY, int valueMin, int valueMax)
{
    double[,] array = new double[sizeX, sizeY];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * (valueMin - valueMax) + valueMax, 2);
        }
    }
    return array;
}

// Вывод массива в консоль.
void PrintArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] testArray = GetArray (10, 10, -1, 1);
PrintArray (testArray);