// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumElements (int[] arr){                            // Сложение чисел стоящих на нечетных позициях
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) result += arr[i];
    }
    return result;
}

int[] array = GetRandomArr (5, -100, 100);              // Создание массива и вызов метода его заполнения
Console.WriteLine ($"[{String.Join(", ", array)}] -> {SumElements(array)}");        // Вывод результата