// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear ();
int ReadNumberInt(string msg)                           // Ввод числа 
{                                              
        Console.Write($"{msg}");
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
}

int n = ReadNumberInt ("Введите число: ");              // Запрос на ввод числа
Console.Write ($"{n} -> ");
for (int i = 1; i <= n; i++){                           // Расчет кубов чисел от 1 до n
    if (i == n) Console.Write ($" {Math.Pow(i, 3)}");
    else {
        Console.Write ($" {Math.Pow(i, 3)},");
    }
}