//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число = ");
string Number = Console.ReadLine();
if(Number.Length !=3)
{
    Console.WriteLine("Неправильное кол-во символов");
}
else
{
    int number = int.Parse(Number);
    Console.WriteLine("Вторая цифра: "+ (number/10)%10);
}