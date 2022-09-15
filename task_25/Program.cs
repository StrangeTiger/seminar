// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

using static System.Console;
Clear();

Write("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
WriteLine();
WriteLine("Введите число А: ");
int number = int.Parse(Console.ReadLine());
WriteLine("Введите число B: ");
int extent = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 1; i <= extent; i++)
{
    result *= number;
}

WriteLine($"Ответ: {number} в степени {extent} = {result}");




