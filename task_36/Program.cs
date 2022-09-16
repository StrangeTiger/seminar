// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] number=new int[size];
FillArrayRandomNumbers(number);
PrintArray(number);

int sum = 0;
for (int i = 0; i < number.Length; i+=2)
{
    sum += number[i];
}

WriteLine();
WriteLine($"Всего {number.Length} числа(ел), сумма элементов на нечётных позициях = {sum}");


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
        numbers[i] = new Random().Next(-999,999);
    }
}

