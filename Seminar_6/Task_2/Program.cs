// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double[] IntersectionPoint (double[] n)
{
    double[] intPoint = new double[2];
    intPoint[0] = Math.Round((n[0]-n[2])/(n[3]-n[1]), 2);
    intPoint[1] = Math.Round(n[3]*intPoint[0]+n[2], 2);
    return intPoint;
}

double[] GetArrFromStr (string strArr)
{
    string[] nums = strArr.Split(" ");
    double[] res = new double[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

Console.Write ("Введите значения b1, k1, b2, k2 через пробел: ");
string elements = Console.ReadLine();
double[] coord = GetArrFromStr(elements);
Console.Write ($"[{String.Join(", ", coord)}] -> ({String.Join("; ", IntersectionPoint(coord))})"); 