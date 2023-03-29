// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2     3   7   -> 7
// 44    5   78  -> 78
// 22    3   9   -> 22


int[] numbers = new int[3];                             // Создание массива для хранения чисел
string[] str = new string[3] {"А", "В", "С"};           // Массив обозначения чисел
int max = 0;

for (int i = 0; i < 3; i++){                            // Ввод чисел
    Console.Write ($"Число {str[i]} = ");
    numbers[i] = Convert.ToInt32(Console.ReadLine ());
}

for (int i = 0; i < 3; i++) {                           // Вычисление наибольшего
    if (max < numbers[i]) max = numbers[i];
}

Console.WriteLine ($"max = {max}");