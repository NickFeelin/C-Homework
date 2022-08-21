/*
Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());

int Degree(int num, int degree)
{
    int res = 1;
    for(int i = 1; i <= degree; i++)
    {
        res *= num;
    }
    return res;
}

//Console.Write($"Число {a} в степени {b} равно {num}");
Console.WriteLine(Degree(a, b));
Console.WriteLine();