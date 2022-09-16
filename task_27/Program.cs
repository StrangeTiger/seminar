// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

WriteLine("Введите число: ");
int number = int.Parse(ReadLine());
int sumNumber = 0;

while (number != 0)
{
    sumNumber += number % 10;
    number /= 10;
}
WriteLine($"Сумма цифр в числe = {sumNumber}");