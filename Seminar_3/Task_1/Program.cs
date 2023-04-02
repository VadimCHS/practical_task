// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int ReadNumberInt(string msg)                           // Ввод числа 
{                                              
        Console.Write("Введите число" + $" {msg}" + ": ");
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
}

bool TestPalindrom(int a)
{
    Console.Write($"{a} -> ");
    int n = 0;
    for (int i = a; i != 0; i = i / 10)                 // Вычисление длины числа
    {
        n++;
    }
    int[] palindrom = new int[n];
    for (int i = 0; i < n; i++)                         // Запись цыфр числа в массив
    {
        palindrom[n - 1 - i] = a % 10;
        a = a / 10;
    }
    for (int i = 0; i != n - 1 - i; i++)                    // Проверка массива (палиндром/не палиндром)
    {
        if (palindrom[i] != palindrom[n - 1 - i])
        {
            return false;
        }
    }
    return true;
}

int n = 0;          // Введенное число
bool a = true;      // Для цикла проверки введеного числа

 while (a)
{
    n = ReadNumberInt(" из пяти цифр");
    if (Math.Abs(n) > 10000 && Math.Abs(n) < 100000) a = false;     // Проверка введеного числа
    else Console.WriteLine("Введено не корректное число!!!");
}

if (TestPalindrom(n)) Console.WriteLine("палиндром"); // Вызов метода проверки числа и вывод результата
else Console.WriteLine("не палиндром");