//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точек");
Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
double distance = Math.Round(d,2);

System.Console.WriteLine($"Расстояние между точками равно = {distance}");
