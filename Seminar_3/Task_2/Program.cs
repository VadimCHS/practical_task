// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadNumberInt(string msg)                           // Ввод числа 
{                                              
        Console.Write($"{msg} -> ");
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
}

double Distance (int[] a, int[] b){                     // Расчет расстояние между точками
    double result = 0.00;
    for (int i = 0; i < a.Length; i++){
        result += Math.Pow(a[i] - b[i], 2);
    } 
    result = Math.Sqrt(result);
    return result;
}

string[] nameCoordinates = {"A", "B"};
string[] coordinates = {"x", "y", "z"};
int[] a = new int [3];
int[] b = new int [3];
for(int i = 0; i < nameCoordinates.Length; i++){                    // Запрос на ввод координат
    Console.WriteLine ($"Введите координаты точки {nameCoordinates[i]}:");
    for (int j = 0; j < a.Length; j++){
        if (i == 0) a[j] = ReadNumberInt(coordinates[j]);
        else b[j] = ReadNumberInt(coordinates[j]);
    }
}

Console.WriteLine ($"A({a[0]}, {a[1]}, {a[2]}) B({b[0]}, {b[1]}, {b[2]}) -> {Distance (a, b):f2}"); // Вывод расчета расстояния между точками
