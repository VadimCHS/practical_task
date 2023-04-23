// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

// Сортировка строки массива по убыванию.
void SortLineArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, j] < inArray[i, k])
                {
                    int n = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = n;
                }
            }
        }
    }
}

Write("Укажите колличество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Укажите колличество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] testArray = GetArray(rows, columns, 0, 10);  // Создание и заполнение массива.
PrintArray(testArray);                              // Вывод массива в консоль.
WriteLine();            
SortLineArray(testArray);                           // Сортировка строк массива по убыванию.
WriteLine("Массив после сортировки строк: ");
PrintArray(testArray);                              // Вывод массива в консоль.