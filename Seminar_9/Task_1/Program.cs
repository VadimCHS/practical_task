// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

// Запись чисел в строку от N до M.
string Enumeration(int fromNumber, int doNumber)
{
    if (fromNumber == doNumber) return fromNumber.ToString();
    return fromNumber + ", " + Enumeration(--fromNumber, doNumber);
}

Console.Write("Введите число: ");
int fromNumber = int.Parse(Console.ReadLine());
Console.Write($"N = {fromNumber} -> {Enumeration(fromNumber, 1)}");