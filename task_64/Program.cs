//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


using static System.Console;
Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

interNumbers(number);

void interNumbers (int number)
{
    if (number == 0) return;
    Console.Write(number + " ");
    interNumbers (number - 1);
}


