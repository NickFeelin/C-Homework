/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементом массива
*/

double[] GetArray(int size)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round((new Random().Next(1, 100) * new Random().NextDouble()), 2); // Не знаю можно ли так поступить в данном задании, но это лучший результат из всех
    }
    return res;
}

double FindDif(double[] num)
{
    double max = num[0];
    double min = num[0];
    double sum = 0;

    for (int i = 0; i < num.Length; i++)
    {
        if (max < num[i]) max = num[i];
        if (min > num[i]) min = num[i];
        sum = Math.Round((max - min), 2);
    }
    return sum;
}


double[] array = GetArray(4);
Console.WriteLine(String.Join("  ", array));
Console.WriteLine();
Console.Write($"{FindDif(array)}");