// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] number=new int[size];
FillArrayRandomNumbers(number);
PrintArray(number);

int count = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
        count++;
}
WriteLine();
WriteLine($"Всего {number.Length} чисел, {count} из них чётные");



void PrintArray(int[] number)
{
    Write("[ ");
    for (int i = 0; i < number.Length; i++)
    {
        Write(number[i] + " ");
    }
    Write("]");
}

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,999);
    }
}
