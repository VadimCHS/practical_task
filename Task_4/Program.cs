﻿// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write ("Введите положительное число = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine ($"Четные числа от 1 до {n}:");
for (int i=1; i<=n; i++){
    if (i%2==0) Console.Write ($" {i} ");           // Проверка чисел на четность и вывод
}