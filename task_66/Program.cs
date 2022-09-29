// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(($"Сумма цифр от {m} до {n} = {CalculatorSum(m - 1, n)}"));

int CalculatorSum(int m, int n)
{
    int res = m;
    if (m == n) return 0;
    else
    {
        m++;
        res = m + CalculatorSum(m, n);
        return res;
    }
}