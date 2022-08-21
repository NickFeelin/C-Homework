/*
Разобраться с алгоритмом сортировка методом пузырька.
Реализовать невозрастающую сортиовку.
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

void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 1; j < arr.Length - i; j++)
        {
            if (arr[j] < arr[j - 1])
            {
                int place = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = place;
            }  
        }
    }
}

int[] array = GetArray(10);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();
BubbleSort(array);
Console.WriteLine(String.Join(" ", array));