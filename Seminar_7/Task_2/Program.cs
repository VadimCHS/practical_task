// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

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

// П
int ValueArray(int[,] array, int arrayX, int arrayY)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == arrayX && j == arrayY) return array[i, j];
        }
    }
    return -1;
}

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

int[,] testArray = GetArray(3, 4, 0, 10);
PrintArray(testArray);
Console.Write ("Введите позицию элемента через пробел (х y): ");
int[] position = GetArrFromStr(Console.ReadLine());
int n = ValueArray(testArray, position[0], position[1]);
Console.Write (n>= 0 ? $"[{position[0]}, {position[1]}] -> {n}":$"[{position[0]}, {position[1]}] -> Нет числа");
