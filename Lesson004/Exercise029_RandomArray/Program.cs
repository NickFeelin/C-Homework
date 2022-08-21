/*
Напишите программу, которая задаёт массив из N элементов, заполненных случайными числами
из  [a, b) и выводит их на экран
*/

Console.Write("Введите количество элементов массива: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Введите границы массива: ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());


/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(a, b);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }
}
int[] array = new int[N];

FillArray(array);
PrintArray(array);*/

int[] Array(int start, int end, int Num)
{
    int[] massive = new int[N];
    for(int i = 0; i < N; i++)
    {
        massive[i] = new Random().Next(start, end);
        Console.Write(massive[i] + " ");
    }
    return massive;
    //Console.WriteLine($"[{String.Join(", ", massive)}]");
}

Console.WriteLine(Array(a, b, N));

// В терминале начало выдавать "System.Int32[]" после результата, пока не сообразил как исправить