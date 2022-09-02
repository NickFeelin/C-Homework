/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
*/

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
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

void FindAverageColumn(int[,] matr)
{   
    int[] sum = new int[matr.GetLength(1)];
    int count = 0;
    int sumColum = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum[i] = 0;
            for (int k = 0; k < matr.GetLength(0); k++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sum[i] += matr[k, j];
                    sumColum = sum[i];
                    count++;
                }
                Console.WriteLine();
            }
    {
        Console.WriteLine(sumColum / count);
    }
    }
}

int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindAverageColumn(matrix);