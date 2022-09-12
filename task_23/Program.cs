//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write($"Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= cube; i++)
{
    Console.WriteLine(i * i * i);
}


