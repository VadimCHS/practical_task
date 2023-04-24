// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

// Функция Аккермана.
int FunctionAkkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (m > 0 && n == 0) return (FunctionAkkerman(m - 1, 1));
    return (FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1)));
}

Console.WriteLine("Введите два неотрицательных числа m и n.");
Console.Write("m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"m = {m}; n = {n} -> {FunctionAkkerman(m, n)}");