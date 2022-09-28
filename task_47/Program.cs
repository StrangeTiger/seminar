// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using static System.Console;
Clear();

Console.Write("Введите количество строк M: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов N: ");
int columns = int.Parse(Console.ReadLine());
double[,] numbers = new double[lines, columns];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}


