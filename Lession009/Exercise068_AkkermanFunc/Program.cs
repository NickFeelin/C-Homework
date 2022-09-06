/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
Даны два неотрицательных числа m = 2, n = 3; A(m,n) = 29
*/

int FuncAkk(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return FuncAkk(n - 1, 1);
    }
    else
    {
        return FuncAkk(n - 1, FuncAkk(n, m - 1));
    }  

}

Console.WriteLine("Введите первое значение функции");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе значение функции");
int B = int.Parse(Console.ReadLine());

FuncAkk(A, B);
Console.Write($"{FuncAkk(A,B)}");
Console.WriteLine();