/*
Напишите программу, которая на вход принимает позиции элемента в дмумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет
*/

// Не смог реализовать однократный вывод "Указанного элемента не существует"
// Не смог представить нумерацию строк и столбцов с 1-го элемента, а не 0-го

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

void FindPosition(int[,] matr)
{
    //int position = 0;

    Console.WriteLine("Введите номер строки: ");
    int x = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите номер столбца: ");
    int y = int.Parse(Console.ReadLine());

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == x && j == y) Console.WriteLine($"Значение выбранного элемента равно: {matr[x, y]}");
            //Console.WriteLine($"Значение выбранного элемента: {position}");
            if (matr.GetLength(0) < x || matr.GetLength(1) < y) Console.WriteLine("Указанного элемента не существует");
        }
    }
}



int[,] matrix = new int[4, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindPosition(matrix);

