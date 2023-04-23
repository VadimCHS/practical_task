// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

Clear();

// Создание трехмерного массива массива и заполнение случайными числами в заданном диапозоне.
int[,,] GetArray(int sizeX, int sizeY, int sizeZ)
{
    int[,,] result = new int[sizeZ, sizeY, sizeX];
    int[] helpArray = new int[sizeY * sizeX * sizeZ];             // Вспомогательный массив для случайных неповторяющихся чисел.
    int count = 0;                                              // Счетчик вспомогательного массива.
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++, count++)
            {
                helpArray[count] = new Random().Next(10, 100);
                result[i, j, k] = helpArray[count];
                for (int m = 0; m < count; m++)
                {
                    if (helpArray[count] == helpArray[m])       // Проверка на повторение чисел.
                    {
                        count--;
                        k--;
                        break;
                    }
                }
            }

        }
    }
    return result;
}

// Вывод трехмерного массива в консоль.
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k]} ({i},{j},{k})  ");
            }
            WriteLine();
        }
        WriteLine();
    }
}

// Перевод строки в целочисленный массив.
int[] GetArrFromStr (string strArr)
{
    string[] nums = strArr.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

WriteLine ("Размер трехмерного массива не должен превышать 89 элементов!!!");
Write ("Введите размер трехмерного массива через пробел: ");
int[] sizeArray = GetArrFromStr(ReadLine());
if (sizeArray[0] * sizeArray[1] * sizeArray[2] > 89)
{
    Write ("Не верно введен размер массива!!!");
}
else
{
    int[,,] testArray = GetArray(sizeArray[0], sizeArray[1], sizeArray[2]);
    PrintArray(testArray);
}
