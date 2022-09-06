/*
Задайте значения M N. Напишите программу, которая найдет сумму 
натуральных элементов в промежутке от M до N
*/

int SumRec(int M, int N)
{
   return M == N ? N : M + SumRec(M + 1, N);
}

Console.Write("M = ");
int min = int.Parse(Console.ReadLine());
Console.Write("N = ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SumRec(min, number));