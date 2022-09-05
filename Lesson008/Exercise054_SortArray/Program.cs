/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
каждой строки двумерного массива
*/

int[,] GetArray(int arr, int col, int beginNum, int endNum)
{
    int[,] matr = new int[arr, col];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(beginNum, endNum + 1);
        }
    }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    int place = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = place;
                }  
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int arr = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());

Console.Write("Начало диапазона значений: ");
int beginNum = int.Parse(Console.ReadLine());

Console.Write("Конец диапазона значений: ");
int endNum = int.Parse(Console.ReadLine());

int[,] matrix = GetArray(arr, col, beginNum, endNum);
PrintArray(matrix);
Console.WriteLine();

BubbleSort(matrix);
PrintArray(matrix);
