// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using static System.Console;
Clear();

WriteLine("Программа задает массив из 8 элементов и выводит на экран");

int [] array = new int[8];

void PrintArray(int[] array)
{
    Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + " ");
    }
    Write("]");
}

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100);
    }
}

PrintArray(array);
FillArrayRandomNumbers(array);
WriteLine();
PrintArray(array);


