/*Напишите программу, которая принимает на вход число (N)
и выдает таблицу кубов чисел от 1 до N
*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
    Console.Write(Math.Pow(i, 3) + ", ");
