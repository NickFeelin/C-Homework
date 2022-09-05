/*
Задайте прямоугольный двумерный массив. Напишите программу, которая
будет находить строку с наименьшей суммой элементов
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

void FindMinRow(int[,] arr)
{
    int minIndex = 0;
    int[] sum = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) sum[i] += arr[i, j]; 

        for (int k = 0; k < arr.GetLength(0); k++)
        {
            int minRow = sum[i];
            if (sum[k] < minRow)
            {
                minRow = sum[k];
                minIndex = k;
            }

        }
    }
    Console.WriteLine($"Номер наименьшей строки {minIndex}");
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
FindMinRow(matrix);
Console.WriteLine();
