// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
double[] GetRandomArr(int size, int a, int b)              // Заполнение массива случайными числами в заданом диапозоне
    {
        double[] result = new double[size];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = Math.Round(new Random().NextDouble() * (b - a) + a, 2);
        }
        return result;
    }

double[] MinMax (double[] arr){                               // Нахождение минимального и максимального элемента массива
    double[] result = new double[2];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = arr [0];                            
    }

    foreach (var el in arr)
    {
        result[0] = result[0] > el ? el: result[0];     // Минимальный
        result[1] = result[1] < el ? el: result[1];     // Максимальный
    }
    return result;
}

double[] array = GetRandomArr (5, -100, 100);              // Создание массива и вызов метода его заполнения
double[] minMax = MinMax (array);                          // Вызов метода нахождение минимального и максимального элемента массива
Console.WriteLine ($"Max: {minMax[1]}        Min: {minMax[0]}");      // Вывод минимального и максимального числа массива
Console.WriteLine ($"[{String.Join("; ", array)}] -> {(minMax[1]-minMax[0]):f2}");        // Вывод результата