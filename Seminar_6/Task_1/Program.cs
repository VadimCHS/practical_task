// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

int[] GetArrFromStr (string strArr)
{
    string[] nums = strArr.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int Pos (int[] n)
{
    int count = 0;
    foreach (var el in n)
    {
        count += el > 0 ? 1: 0;
    }
    return count;
}

Console.WriteLine ("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
int[] n = GetArrFromStr(elements);
Console.Write ($"[{String.Join(", ", n)}] -> {Pos(n)}"); 