// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5    b = 7   -> max = 7
// a = 2    b = 10  -> max = 10
// a = -9   b = -3  -> max = -3


Console.Write ("Число А = ");
int numberA = Convert.ToInt32(Console.ReadLine ()); // Ввод числа А
Console.Write ("Число В = ");
int numberB = Convert.ToInt32(Console.ReadLine ()); // Ввод числа В
if (numberA < numberB) {                            // Вычисление наибольшего и наименьшего числа
    int n = numberA;                                    
    numberA = numberB;
    numberB = n;
}
Console.WriteLine ($"max = {numberA}");
Console.WriteLine ($"min = {numberB}");