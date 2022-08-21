/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
стоящих на нечетных позициях
*/

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-99, 100);
    }
    return res;
}

int OddSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum += arr[i]; 
    }
    return sum;
}

int[] array = GetArray(10);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();
Console.WriteLine($"{OddSum(array)}");