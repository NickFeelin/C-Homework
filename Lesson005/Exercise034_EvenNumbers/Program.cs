/*
Задайте массив, заполненный случайными положительными трехзначными числами. Наишите программу,
которая покажет количество четных чисел в массиве
*/

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int EvenNumbers(int[] number)
{
    int count = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] % 2 == 0)
        count++;
    }
    return count;
}

int[] array = GetArray(4);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();
Console.WriteLine($"{EvenNumbers(array)}");