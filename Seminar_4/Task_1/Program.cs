// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumberInt(string msg)                           // Ввод числа 
{                                              
        Console.Write(msg);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
}

double Exponentiate (double a, int b){                        // Возведение числа А в степень В
    double result = 1;
    if (b == 0) return result;
    else {
        for (int i = 1; i <= b ; i++){
        result *= a;
        }
        return result;
    }
}

int a = ReadNumberInt ("Введите число: ");
int b = ReadNumberInt ("Введите степень: ");
Console.WriteLine ($" в степени  = {Exponentiate(a, b)}");