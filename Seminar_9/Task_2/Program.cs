// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

// Суммы натуральных чисел от N до M.
int SumNumbers(int fromNumber, int doNumber)
{
    if (fromNumber == doNumber) return doNumber;
    return (fromNumber + SumNumbers(++fromNumber, doNumber));
}

Console.WriteLine("Сумма натуральных чисел от N до M");
Console.Write("Укажите число N: ");
int fromNumber = int.Parse(Console.ReadLine());
Console.Write("Укажите число M: ");
int doNumber = int.Parse(Console.ReadLine());
Console.Write($"N = {fromNumber}; M = {doNumber} -> {SumNumbers(fromNumber, doNumber)}");