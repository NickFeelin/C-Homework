/*
Напишите функцию и запустите ее, которая принимает на вход число и выдает сумму цифр в числе
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int Numbers(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }
    return sum;
}

Console.WriteLine(Numbers(num));
//Console.Write($"Сумма цифр числа {num} равна {sum}");
Console.WriteLine();
