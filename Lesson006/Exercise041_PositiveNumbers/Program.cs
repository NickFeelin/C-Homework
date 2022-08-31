/*
Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь
*/

int[] HandArray(int mas)
{
    int[] arr = new int [mas];

    for (int i = 0; i < mas; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int PositiveVerification(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите общее количество чисел: ");
int m = int.Parse(Console.ReadLine());

int[] array = HandArray(m);
Console.Write(String.Join((" "), array));
Console.WriteLine();
int positiveCount = PositiveVerification(array);
Console.WriteLine($"Количество положительных чисел равно {positiveCount}");