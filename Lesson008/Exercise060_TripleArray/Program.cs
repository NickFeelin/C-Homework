/*
Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите
программу, которая будет построчно выводить массив, добавляя индексы
каждого элемента
*/
int[,,] GetArray(int size)
{
    int[,,] array = new int[size, size, size];
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 2; j++)
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                if (array[i, j, k] == array [0, 0, 0])
                {
                    array[i, j, k] = array[i, j, k] + 1;
                }
                Console.WriteLine($"{array[i, j, k]}" + "({0},{1},{2})", i, j, k);
            }
    return array;
}

int[,,] matrix = GetArray(2);
