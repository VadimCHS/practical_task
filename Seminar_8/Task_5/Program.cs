// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

Clear();

// Создание двухмерного массива и заполнение случайными числами в заданном диапозоне по спирали.
int[,] GetArray(int sizeRows, int sizeColumns)
{   
    int[,] result = new int[sizeColumns, sizeRows];
    int n = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        result[0, i] = n;
        n++;
    }
    for (int i = 1; i < result.GetLength(1); i++)
    {
        result[i,result.GetLength(0)-1] = n;
        n++;
    }
    for (int i = result.GetLength(0)-2; i >= 0; i--)
    {
        result[result.GetLength(1)-1,i] = n;
        n++;
    }
    for (int i = result.GetLength(0)-2; i > 0; i--)
    {
        result[i,0] = n;
        n++;
    }
    for (int i = 1; i < result.GetLength(0)-1; i++)
    {
        result[1,i] = n;
        n++;
    }
    for (int i = 2; i < result.GetLength(0)-1; i++)
    {
        result[i,2] = n;
        n++;
    }
    for (int i = result.GetLength(1)-3; i > 0; i--)
    {
        result[2,i] = n;
        n++;
    }
    return result;
}

// Вывод двухмерного массива в консоль.
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}      ");
        }
        WriteLine();
    }
}

int[,] testArray = GetArray(4, 4);
PrintArray(testArray);