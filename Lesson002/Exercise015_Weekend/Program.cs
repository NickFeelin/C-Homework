/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли он выходным.
*/
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7)
    Console.Write("Это выходной!");
else 
    if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)

        Console.Write("Это будний день");
    else 
        Console.Write("Такого дня недели не существует");

/*switch (day)
{
    case 1:
    Console.Write("Это будний день :( ");
    break;

    case 2:
    Console.Write("Это будний день :( ");
    break;

    case 3:
    Console.Write("Это будний день :( ");
    break;

    case 4:
    Console.Write("Это будний день :( ");
    break;

    case 5:
    Console.Write("Это будний день :( ");
    break;

    case 6:
    Console.Write("Это выходной!! :D ");
    break;

    case 7:
    Console.Write("Это выходной!! :D ");
    break;

    default:
    Console.Write("Дня недели с таким номером не существует.");
    break;
}*/