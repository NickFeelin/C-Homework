/*  Напишите программу, которая принимает на вход трехзначное число 
    и на выходе показывает вторую цифру этого числа
*/
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine());

int a1 = (number / 10) % 10;
//int a2 = ((number - a1) / 10) % 10;

Console.WriteLine($"Вторая цифра числа {number} это {a1}");

