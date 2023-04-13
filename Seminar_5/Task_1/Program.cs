// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] GetRandomArr(int size, int a, int b)              // Заполнение массива случайными числами в заданом диапозоне
    {
        int[] result = new int[size];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = new Random().Next(a, b + 1);
        }
        return result;
    }

int EvenNumbers (int[] arr){                            // Подсчет четных чисел в массиве
    int result = 0;
    foreach (var el in arr)
    {
        result += el % 2 == 0 ? 1: 0;
    }
    return result;
}

int[] array = GetRandomArr (10, 100, 999);              // Создание массива и вызов метода его заполнения
Console.WriteLine ($"[{String.Join(", ", array)}] -> {EvenNumbers(array)}");        // Вывод результата