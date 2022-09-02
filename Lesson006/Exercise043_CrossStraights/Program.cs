/*
Напишите программу, которая найдет точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2, k2
задаются пользователем
*/

void FillArray(float[,] a)
{
    Console.WriteLine("Введите значение b1: ");
    a[0, 0] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение k1: ");
    a[0, 1] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение b2: ");
    a[1, 0] = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение k2: ");
    a[1, 1] = int.Parse(Console.ReadLine());
}

void PrintArray(float[,] matr)
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

void CrossLinesPoint(float[,] mas)
{
    float x = (mas[1, 0] - mas[0, 0]) / (mas[0, 1] - mas[1, 1]);
    float y = mas[0, 1] * x + mas[0, 0];
    Console.WriteLine($"Точка пересечения прямых соответсвует координатам ({x};{y})");
}

float[,] massive = new float[2, 2];
FillArray(massive);
PrintArray(massive);
CrossLinesPoint(massive);
Console.WriteLine();