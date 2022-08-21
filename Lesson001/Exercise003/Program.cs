Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
    Console.Write("Понедельник");
    break;

    case 2:
    Console.Write("Вторник");
    break;

    case 3:
    Console.Write("Среда");
    break;

    case 4:
    Console.Write("Четверг");
    break;

    case 5:
    Console.Write("Пятница");
    break;

    case 6:
    Console.Write("Суббота");
    break;

    case 7:
    Console.Write("Воскресенье");
    break;

    default:
    Console.Write("Дня недели с таким номером не существует.");
    break;
}

//if (day == 1)
//    Console.Write("Понедельник");
//if (day == 2)
//    Console.Write("Вторник");
//if (day == 3)
//    Console.Write("Среда");
//if (day == 4)
//    Console.Write("Четверг");
//if (day == 5)
//    Console.Write("Пятница");
//if (day == 6)
//    Console.Write("Суббота");
//if (day == 7)
//    Console.Write("Воскресенье");   

