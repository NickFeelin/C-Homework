/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
*/

int[,] GetArray(int side, int beginNum, int endNum)
{
    int[,] matr = new int[side, side];

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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrixResult = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            matrixResult[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                matrixResult[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return matrixResult;
}


Console.Write("Введите размер стороны: ");
int side = int.Parse(Console.ReadLine());

Console.Write("Начало диапазона значений: ");
int beginNum = int.Parse(Console.ReadLine());

Console.Write("Конец диапазона значений: ");
int endNum = int.Parse(Console.ReadLine());

int[,] matrix = GetArray(side, beginNum, endNum);
PrintArray(matrix);
Console.WriteLine();
int[,] array = GetArray(side, beginNum, endNum);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц: ");
int[,] result = MatrixMultiplication(matrix, array);
PrintArray(result);
Console.WriteLine();