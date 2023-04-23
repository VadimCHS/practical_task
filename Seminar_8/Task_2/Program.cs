// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка.

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

// Поиск строки с наименьшей суммой элементов.
int GetMinSumLines(int[,] inArray)
{
    int result = 0;
    int[] sum = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum[i] += inArray[i, j];
        }
        if (i > 0) result = sum[result] > sum[i] ? i : result;
        // WriteLine ($"sum[{result}] = {sum[result]}; sum[{i}] = {sum[i]} ");
        // WriteLine($"Строка {result}");
    }
    return result;
}

Write("Укажите колличество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Укажите колличество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] testArray = GetArray(rows, columns, 0, 10);  // Создание и заполнение массива.
PrintArray(testArray);                              // Вывод массива в консоль.
WriteLine();
Write($"Строка с наименьшей суммой: {GetMinSumLines(testArray)}"); // Вывод номера строки с наименьшей суммой элементов.