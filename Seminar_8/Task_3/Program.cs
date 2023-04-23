// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;

Clear();

// Создание двухмерного массива и заполнение случайными числами в заданном диапозоне.
int[,] GetArray(int sizeRows, int sizeColumns, int valueMin, int valueMax)
{
    int[,] array = new int[sizeRows, sizeColumns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(valueMin, valueMax + 1);
        }
    }
    return array;
}

// Вывод двухмерного массива в консоль.
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}  ");
        }
        WriteLine();
    }
}

// Перевод строки в числовой массив.
int[] GetArrFromStr(string strArr)
{
    string[] nums = strArr.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

// Умножение матриц.
int[,] MultiplicationMatrix(int[,] inMatrix1, int[,] inMatrix2)
{
    int[,] result = new int[inMatrix1.GetLength(0), inMatrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, j] += inMatrix1[i, k] * inMatrix2[k, j];
            }
        }
    }
    return result;
}


WriteLine("Произведение двух матриц имеет смысл в том случае, когда число столбцов первой матрицы совпадает с числом строк второй матрицы.");
Write("Укажите размер первой матрицы (M x N) через пробел: ");
int[] sizeMatrix1 = GetArrFromStr(ReadLine());
Write("Укажите число столбцов второй матрицы: ");
int columnsMatrix2 = int.Parse(ReadLine());
WriteLine();
int[,] testMatrix1 = GetArray(sizeMatrix1[0], sizeMatrix1[1], 0, 10);   // Заполнение матриц.
int[,] testMatrix2 = GetArray(sizeMatrix1[1], columnsMatrix2, 0, 10);   // Заполнение матриц.
WriteLine("Первая матрица:");
PrintArray(testMatrix1);
WriteLine();
WriteLine("Вторая матрица:");
PrintArray(testMatrix2);
WriteLine();
WriteLine("Результат умножение матриц:");
PrintArray(MultiplicationMatrix(testMatrix1, testMatrix2));             // Умножение матриц.

