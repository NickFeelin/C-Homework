/*Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между ними в 3D пространстве
*/
Console.WriteLine("Введите координаты точки А: ");
Console.Write("X = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z = ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("X = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Y = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Z = ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками A и B в трехмерной плоскости равно {distance:f2}");