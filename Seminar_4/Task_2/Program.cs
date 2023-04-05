// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumberInt(string msg)                           // Ввод числа 
{                                              
        Console.Write(msg);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
}

int SumNumbers (int n){                                 // Расчет суммы цифр в числе
    int result = 0;
    for (int i = n; i != 0; i /= 10){
        result += n % 10;
        n /= 10;
    }
    return result;
}

int n = ReadNumberInt ("Введите число: ");
Console.WriteLine ($"{n} -> {Math.Abs(SumNumbers (n))}");// Вывод суммы цифр в числе