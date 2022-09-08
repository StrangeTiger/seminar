// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите цифру от 1 до 7, которая обозначает день недели");
int DayOfWeek = int.Parse(Console.ReadLine());
if (DayOfWeek < 8 && DayOfWeek > 0)
{
    if (DayOfWeek == 6 || DayOfWeek == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Будний");
    }
}
else
{
    Console.WriteLine("Введенное число выходит из диапазона от 1 до 7");
}