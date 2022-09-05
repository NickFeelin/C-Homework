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
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int place = arr[i];
                arr[i] = arr[j];
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