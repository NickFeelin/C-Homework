/*
Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В
*/

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите степень: ");
int b = int.Parse(Console.ReadLine());

int num = 1;

int Degree()
{
    for(int i = 0; i < b; i++)
    {
        num *= a;
    }
    return num;
}
Degree();

Console.Write($"Число {a} в степени {b} равно {num}");
Console.WriteLine();