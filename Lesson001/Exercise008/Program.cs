Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Четные числа: ");
for (int index = 0; index <= number; index++)
{
    if (index % 2 == 0)
        Console.Write("{0} ", index);
}
