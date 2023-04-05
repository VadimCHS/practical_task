// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadNumberInt(string msg)                           // Ввод числа 
{                                              
        Console.Write(msg);
        int result = Convert.ToInt32(Console.ReadLine());
        return result;
}

int RandomNumberInt (int a, int b)                       // Случайное число с заданием диапозона
{                                              
        int result = new Random().Next(a, b + 1);
        return result;
}

Console.WriteLine ("Введите диапозон заполнения массива: ");
int a = ReadNumberInt("От -> ");
int b = ReadNumberInt("До -> ");
int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++){                      // Заполнение массива   
    arr[i] = RandomNumberInt (a, b);
}

Console.WriteLine ($"{String.Join(", ", arr)} -> [{String.Join(",",arr)}]"); // Вывод массива

