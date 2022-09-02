/*
Задайте двумерный массив размером m * n, заполненный случайными вещественными числами
*/

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((new Random().Next(-9, 10) * new Random().NextDouble()), 1);
        }
    Console.WriteLine();
    }
}

void PrintArray(double[,] matr)
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

Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);