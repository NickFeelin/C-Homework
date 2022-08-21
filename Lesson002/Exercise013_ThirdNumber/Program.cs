/*  Напишите программу, которая выводит третью цифру 
    заданного числа или сообщает, что третьей цифры нет.
*/
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int one = (number / 100) % 10;
//int hundred = (number - one) / 100;
//int third = hundred % 10;

if (one > 0)
    Console.Write($"Третья цифра числа {number} это {one}");
else
    Console.Write("Третьей цифры нет");
