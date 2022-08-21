Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
    Console.WriteLine($"Число {numberA} больше числа {numberB} ");
else
    Console.WriteLine($"Число {numberB} больше числа {numberA} ");


