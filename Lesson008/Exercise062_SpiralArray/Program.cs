/*
Напишите программу, которая заполнит спирально массив 4 на 4
*/
int[,] GetArray(int size)
{
    int[,] array = new int[size, size];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int duration = size;

    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = i + 1;
        if (--duration == 0)
        {
            duration = size * (dirChanges % 2) + size * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return array;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            //Console.Write($"{matr[i, j]} ");
            Console.Write("{0, 3}", matr[i, j]);
        }
        Console.WriteLine();
    }
}


int[,] matrix = GetArray(4);
PrintArray(matrix);